function startApp() {
    $('header a').show();
    function showView(view) {
        $('section').hide();
        switch (view) {
            case 'home':
                $('#viewHome').show();
                break;
            case 'login':
                $('#viewLogin').show();
                break;
            case 'register':
                $('#viewRegister').show();
                break;
            case 'ads':
                $('#viewAds').show();
                loadAds();
                break;
            case 'create':
                $('#viewCreateAd').show();
                break;
            case 'details':
                $('#viewDetailsAd').show();
                break;
            case 'edit':
                $('#viewEditAd').show();
                break;
        }
    }

    //Attach event listeners
    $('#linkHome').click(() => showView('home'));
    $('#linkListAds').click(() => showView('ads'));
    $('#linkLogin').click(() => showView('login'));
    $('#linkRegister').click(() => showView('register'));
    $('#linkCreateAd').click(() => showView('create'));
    $('#buttonLoginUser').click(login);
    $('#buttonRegisterUser').click(register);
    $('#linkLogout').click(logout);
    $('#buttonCreateAd').click(createAdvert);

    //Notifications
    $(document).on({
        ajaxStart: () => $('#loadingBox').show(),
        ajaxStop: () => $('#loadingBox').fadeOut()
    });

    $('#infoBox').click((event) => $(event.target).hide());
    $('#errorBox').click((event) => $(event.target).hide());

    function showInfo(message) {
        $('#infoBox').text(message);
        $('#infoBox').show();
        setTimeout(() => $('#infoBox').fadeOut(), 3000);
    }

    function showError(message) {
        $('#errorBox').text(message);
        $('#errorBox').show();
    }

    function handleError(reason) {
        showError(reason.responseJSON.description);
    }

    let requester = (() => {
        const appKey = 'kid_ByTGfoEvW';
        const appSecret = 'b971c16e260948e6ab708ab93baa56fe';
        const baseUrl = `https://baas.kinvey.com/`;

        function makeAuth(type) {
            if (type === 'basic') return 'Basic ' + btoa(appKey + ':' + appSecret);
            else return 'Kinvey ' + localStorage.getItem('authtoken');
        }

        function makeRequest(method, module, url, auth) {
            return req = {
                url: baseUrl + module + '/' + appKey + '/' + url,
                method,
                headers: {
                    'Authorization': makeAuth(auth)
                }
            };
        }

        function get(module, url, auth) {
            return $.ajax(makeRequest('GET', module, url, auth));
        }

        function post(module, url, data, auth) {
            let req = makeRequest('POST', module, url, auth);
            req.data = data;
            return $.ajax(req);
        }

        function update(module, url, data, auth) {
            let req = makeRequest('PUT', module, url, auth);
            req.data = data;
            return $.ajax(req);
        }

        function remove(module, url, auth) {
            return $.ajax(makeRequest('DELETE', module, url, auth));
        }

        return {
            get,
            post,
            update,
            remove
        }
    })();

    if (localStorage.getItem('username') !== null &&
        localStorage.getItem('authtoken') !== null) {
        userLoggedIn();
    } else {
        userLoggedOut();
    }

    showView('home');

    function userLoggedIn() {
        $('#loggedInUser').text(`Welcome ${localStorage.getItem('username')}!`);
        $('#loggedInUser').show();
        $('#linkLogin').hide();
        $('#linkRegister').hide();
        $('#linkCreateAd').show();
        $('#linkListAds').show();
        $('#linkLogout').show();
    }

    function userLoggedOut() {
        $('#loggedInUser').text(``);
        $('#loggedInUser').hide();
        $('#linkLogin').show();
        $('#linkRegister').show();
        $('#linkCreateAd').hide();
        $('#linkListAds').hide();
        $('#linkLogout').hide();
    }

    function saveSession(data) {
        localStorage.setItem('username', data.username);
        localStorage.setItem('id', data._id);
        localStorage.setItem('authtoken', data._kmd.authtoken);
        userLoggedIn();
    }

    async function login() {
        let username = $(`#formLogin input[name='username']`).val();
        let password = $(`#formLogin input[name='passwd']`).val();
        try {
            let data = await requester.post('user', 'login', {username, password}, 'basic');
            saveSession(data);
            showInfo('Logged in');
            showView('ads');
        } catch (err) {
            handleError(err);
        }
    }

    async function register() {
        let username = $(`#formRegister input[name='username']`).val();
        let password = $(`#formRegister input[name='passwd']`).val();

        try {
            let data = await requester.post('user', '', {username, password}, 'basic');
            saveSession(data);
            showInfo('Registered successfully');
            showView('ads');
        } catch (err) {
            handleError(err);
        }
    }

    async function logout() {
        try {
            let data = await requester.post('user', '_logout', {authtoken: localStorage.getItem('authtoken')},);
            localStorage.clear();
            userLoggedOut();
            showInfo('Logged out');
            showView('home');
        } catch (err) {
            handleError(err);
        }
    }

    async function loadAds() {
        let data = await requester.get('appdata', 'adverts');
        $('#ads').empty();
        if (data.length === 0) {
            $('#ads').append('<p>No ads available!</p>');
        }

        for (let ad of data) {
            let html = $('<div>');
            html.addClass('ad-box');
            let title = $(`<div class="ad-title">${ad.title}</div>`).click(() => viewDetails(ad));

            if (ad._acl.creator === localStorage.getItem('id')) {
                let deleteBtn = $('<button>&#10007;</button>')
                    .addClass('ad-control')
                    .click(() => deleteAd(ad._id));
                deleteBtn.appendTo(title);

                let editBtn = $('<button>&#9998;</button>')
                    .addClass('ad-control')
                    .click(() => openEditAd(ad));
                editBtn.appendTo(title);
            }

            html.append(title);
            html.append($(`<div><img src="${ad.imageUrl}"</div>`).click(() => viewDetails(ad)));
            html.append($(`<div>Price: ${(+ad.price).toFixed(2)} By: ${ad.publisher}</div>`));
            $('#ads').append(html);
        }
    }

    async function viewDetails(ad) {
        $('.viewDetailsAd h1').text(ad.title);
        $('.ad img').attr('src', ad.imageUrl);
        $('#ad-desc').addClass('ad-desc');
        $('.ad-desc p').text(ad.description);
        $('#ad-publisher').text(`Publisher: ${ad.publisher}`);
        $('#ad-date').text(ad.datePublished);
        showView('details');
    }

    async function openEditAd(ad) {
        $('#formEditAd input[name="title"]').val(ad.title);
        $('#formEditAd textarea[name="description"]').val(ad.description);
        $('#formEditAd input[name="price"]').val(+ad.price);
        $('#formEditAd input[name="image"]').val(ad.imageUrl);

        let datePublished = ad.datePublished;
        let publisher = ad.publisher;
        $('#buttonEditAd').click(() => editAd(ad._id, datePublished, publisher));
        showView('edit');
    }

    async function editAd(id, datePublished, publisher) {
        let title = $('#formEditAd input[name="title"]').val();
        let description = $('#formEditAd textarea[name="description"]').val();
        let price = $('#formEditAd input[name="price"]').val();
        let imageUrl = $('#formEditAd input[name="image"]').val();

        if (title.length === 0) {
            showError('Title cannot be empty!');
            return;
        }
        if (price.length === 0) {
            showError('Price cannot be empty!');
            return;
        }

        let editedAd = {
            title, description, price, imageUrl, datePublished, publisher
        };

        try {
            await requester.update('appdata', 'adverts/' + id, editedAd);
            showInfo('Ad edited');
            showView('ads');
        } catch (err) {
            handleError(err);
        }
    }

    async function deleteAd(id) {
        await requester.remove('appdata', 'adverts/' + id,);
        showInfo('Ad deleted!');
        showView('ads');
    }

    async function createAdvert() {
        let title = $(`#formCreateAd input[name='title']`).val();
        let description = $(`#formCreateAd textarea[name='description']`).val();
        let price = Number($(`#formCreateAd input[name='price']`).val());
        let imageUrl = $(`#formCreateAd input[name='image']`).val();
        let datePublished = new Date();
        let publisher = localStorage.getItem('username');

        if (title.length === 0) {
            showError('Title cannot be empty!');
            return;
        }
        if (price.length === 0) {
            showError('Price cannot be empty!');
            return;
        }
        if (description.length === 0) {
            showError('Description cannot be empty!');
            return;
        }

        let newAd = {
            title, description, price, imageUrl, datePublished, publisher
        };

        try {
            await requester.post('appdata', 'adverts', newAd);
            showInfo('Ad created');
            showView('ads');
        } catch (err) {
            handleError(err);
        }
    }
}