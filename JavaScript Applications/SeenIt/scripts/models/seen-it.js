let seen = (() => {

    async function getCatalog() {
        let allArticles = await requester.get('appdata', 'posts');
        let articles = [];
        let rank = 1;

        for (let art in allArticles) {
            allArticles[art].rank = rank;
            allArticles[art].submitDate = calcTime(allArticles[art]._kmd.lmt);
            articles.push(allArticles[art]);

            rank++;
        }

        return articles;
    }

    function submitPost(author, url, title, imageUrl, description) {
        let data = {
            author,
            url,
            title,
            imageUrl,
            description
        };

        return requester.post('appdata', 'posts', '', data);
    }

    function displayPost(id) {
        return requester.get('appdata', 'posts/' + id, '');
    }

    async function editPost(id, author, url, title, imageUrl, description) {
        let currentPost = await requester.get('appdata', 'posts/' + id);

        currentPost.author = author;
        currentPost.url = url;
        currentPost.title = title;
        currentPost.imageUrl = imageUrl;
        currentPost.description = description;

        requester.update('appdata', 'posts/' + id, '', currentPost);
    }

    async function deletePost(id) {

        let currentUser = sessionStorage.getItem('username');
        let currentPost = await requester.get('appdata', 'posts/' + id);

        let rows = $('article');
        let currentRow;

        for (let row of rows) {
            if ($(row).attr('data-target') === id) {
                currentRow = row;
            }
        }

        if (currentPost.author === currentUser) {
            requester.remove('appdata', 'posts/' + id)
                .then(function () {
                    auth.showInfo('Post deleted');
                    currentRow.remove();
                }).catch(auth.handleError);
        }
    }

    async function deleteComment(id) {
        let currentUser = sessionStorage.getItem('username');
        let currentComment = await requester.get('appdata', 'comments/' + id);

        let rows = $('article');
        let currentRow;

        for (let row of rows) {
            if ($(row).attr('data-target') === id) {
                currentRow = row;
            }
        }

        if (currentComment.author === currentUser) {
            requester.remove('appdata', 'comments/' + id)
                .then(function () {
                    auth.showInfo('Comment deleted');
                    currentRow.remove();
                }).catch(auth.handleError);
        } else {
            auth.showError('You cannot delete other people\'s comments');
        }

    }

    async function getMyPosts() {
        let allArticles = await requester.get('appdata', 'posts');
        let myArticles = [];
        let currentUser = sessionStorage.getItem('username');
        let rank = 1;

        for (let art in allArticles) {
            if (allArticles[art].author === currentUser) {
                allArticles[art].rank = rank;
                allArticles[art].submitDate = calcTime(allArticles[art]._kmd.lmt);
                myArticles.push(allArticles[art]);

                rank++;
            }

        }

        return myArticles;
    }

    async function getComments(postId) {
        let allComments = await requester.get('appdata', 'comments');
        let myComments = [];

        for (let comment in allComments) {
            if (postId === allComments[comment].postId) {
                allComments[comment].submitDate = calcTime(allComments[comment]._kmd.lmt);
                myComments.push(allComments[comment]);
            }
        }

        return myComments;
    }

    async function createComment(postId, content) {
        let author = sessionStorage.getItem('username');
        let data = {
            postId,
            content,
            author
        };

        return requester.post('appdata', 'comments', '', data);
    }

    function calcTime(dateIsoFormat) {
        let diff = new Date - (new Date(dateIsoFormat));
        diff = Math.floor(diff / 60000);
        if (diff < 1) return 'less than a minute';
        if (diff < 60) return diff + ' minute' + pluralize(diff);
        diff = Math.floor(diff / 60);
        if (diff < 24) return diff + ' hour' + pluralize(diff);
        diff = Math.floor(diff / 24);
        if (diff < 30) return diff + ' day' + pluralize(diff);
        diff = Math.floor(diff / 30);
        if (diff < 12) return diff + ' month' + pluralize(diff);
        diff = Math.floor(diff / 12);
        return diff + ' year' + pluralize(diff);
        function pluralize(value) {
            if (value !== 1) return 's';
            else return '';
        }
    }

    return {
        getCatalog,
        submitPost,
        displayPost,
        editPost,
        deletePost,
        deleteComment,
        getMyPosts,
        getComments,
        createComment
    }
})();