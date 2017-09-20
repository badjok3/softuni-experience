$(() => {

    //NOTIFICATIONS (LOADING)
    $(document).on({
        ajaxStart: () => $('#loadingBox').show(),
        ajaxStop: () => $('#loadingBox').fadeOut()
    });

    const app = Sammy('#container', function () {
        this.use('Handlebars', 'hbs');

        this.get('index.html', function (ctx) {
            ctx.isLogged = sessionStorage.getItem('authtoken') !== null;

            if (ctx.isLogged) {
                displayCatalog(ctx);
            } else {
                displayHome(ctx);
            }
        });

        this.get('#/home', displayHome);

        //LOGIN
        this.post('#/login', function (ctx) {
            let username = ctx.params.username;
            let password = ctx.params.password;

            auth.login(username, password)
                .then(function (userInfo) {
                    auth.saveSession(userInfo);
                    auth.showInfo('Login successful');
                    displayCatalog(ctx);
                }).catch(auth.handleError);
        });

        //REGISTER
        this.post('#/register', function (ctx) {
            let username = ctx.params.username;
            let password = ctx.params.password;
            let repeatPassword = ctx.params.repeatPassword;

            auth.register(username, password, repeatPassword)
                .then(function (userInfo) {
                    auth.saveSession(userInfo);
                    auth.showInfo('Register successful');
                    displayCatalog(ctx);
                }).catch(auth.handleError);
        });

        //LOGOUT
        this.get('#/logout', function (ctx) {
            auth.logout()
                .then(function () {
                    sessionStorage.clear();
                    auth.showInfo('Logout successful');
                    displayHome(ctx);
                }).catch(auth.handleError);
        });

        //CATALOG
        this.get('#/catalog', displayCatalog);

        //SUBMIT POST
        this.get('#/submit', function (ctx) {
            ctx.isLogged = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                notifications: './templates/common/notifications.hbs',
                page: './templates/submit/submitPage.hbs',
                submitForm: './templates/submit/submitForm.hbs',
                navigation: './templates/common/navigation.hbs'
            }).then(function () {
                this.partial('./templates/main.hbs');
            });
        });

        this.post('#/submit', function (ctx) {
            let url = ctx.params.url;
            let title = ctx.params.title;
            let imageUrl = ctx.params.image;
            let description = ctx.params.comment;
            let author = sessionStorage.getItem('username');
            seen.submitPost(author, url, title, imageUrl, description)
                .then(function () {
                    auth.showInfo('Submit successful');
                    displayCatalog(ctx);
                }).catch(auth.handleError);
        });

        //EDIT POST
        this.get('#/edit/:id', async function (ctx) {
            ctx.isLogged = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');

            let id = ctx.params.id.substr(1,);
            let currentPost = await seen.displayPost(id);
            if (currentPost.author === ctx.username) {
                ctx.currentForm = await seen.displayPost(id);
                ctx.loadPartials({
                    header: './templates/common/header.hbs',
                    footer: './templates/common/footer.hbs',
                    notifications: './templates/common/notifications.hbs',
                    page: './templates/edit/editPage.hbs',
                    editForm: './templates/edit/editForm.hbs',
                    navigation: './templates/common/navigation.hbs'
                }).then(function () {
                    this.partial('./templates/main.hbs');
                });
            } else {
                auth.showError('You cannot edit other people\'s posts');
            }
        });

        this.post('#/edit/:id', function (ctx) {
            let url = ctx.params.url;
            let title = ctx.params.title;
            let imageUrl = ctx.params.image;
            let description = ctx.params.description;
            let author = sessionStorage.getItem('username');
            let id = ctx.params.id.substr(1,);

            seen.editPost(id, author, url, title, imageUrl, description)
                .then(function () {
                    auth.showInfo('Post updated');
                    displayCatalog(ctx);
                }).catch(auth.handleError)
        });

        //DELETE POST
        this.get('#/delete/:id', async function (ctx) {
            let id = ctx.params.id.substr(1,);

            seen.deletePost(id)
                .then(function () {
                    displayCatalog(ctx);
                });
        });

        //MY POSTS
        this.get('#/myPosts', async function (ctx) {
            ctx.isLogged = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');
            ctx.posts = await seen.getMyPosts();
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                notifications: './templates/common/notifications.hbs',
                page: './templates/posts/postsPage.hbs',
                post: './templates/posts/post.hbs',
                navigation: './templates/common/navigation.hbs'
            }).then(function () {
                this.partial('./templates/main.hbs');
            });
        });

        //POST DETAILS
        this.get('#/comments/:id', async function (ctx) {
            ctx.isLogged = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');
            let id = ctx.params.id.substr(1,);
            ctx.post = await seen.displayPost(id);
            ctx.comments = await seen.getComments(id);

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                notifications: './templates/common/notifications.hbs',
                page: './templates/comments/commentsPage.hbs',
                comment: './templates/comments/comment.hbs',
                navigation: './templates/common/navigation.hbs'
            }).then(function () {
                this.partial('./templates/main.hbs');
            });
        });

        //POST COMMENT
        //SADLY YOU CAN ONlY SEE YOUR POSTED COMMENTS AFTER REFRESHING :/
        this.post('#/comments/:id', function (ctx) {
            ctx.isLogged = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');
            let postId = ctx.params.id.substr(1,);
            let content = ctx.params.content;
            seen.createComment(postId, content)
                .then(function () {
                    auth.showInfo('Comment created');
                    setTimeout(() => auth.showInfo('Please refresh'), 1000);
                }).catch(auth.handleError);


        });

        //DElETE COMMENT
        this.get('#/deleteComment/:id', function (ctx) {
            let id = ctx.params.id.substr(1,);

            seen.deleteComment(id)
                .catch(auth.handleError);
        });


        async function displayCatalog(ctx) {
            ctx.isLogged = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');
            ctx.articles = await seen.getCatalog();
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                notifications: './templates/common/notifications.hbs',
                page: './templates/catalog/catalogPage.hbs',
                article: './templates/catalog/article.hbs',
                navigation: './templates/common/navigation.hbs'
            }).then(function () {
                this.partial('./templates/main.hbs');
            });
        }

        function displayHome(ctx) {
            ctx.isLogged = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                notifications: './templates/common/notifications.hbs',
                page: './templates/home.hbs',
                navigation: './templates/common/navigation.hbs'
            }).then(function () {
                this.partial('./templates/main.hbs');
            });
        }
    });

    app.run();
});