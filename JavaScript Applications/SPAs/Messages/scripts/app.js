$(() => {
    const app = Sammy('main', function () {
        this.use('Handlebars', 'hbs');

        this.get('index.html', displayHome);

        this.get('#/home', displayHome);

        //LOGIN
        this.get('#/login', function (ctx) {

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                notifications: './templates/common/notifications.hbs',
                page: './templates/loginPage.hbs'
            }).then(function () {
                this.partial('./templates/main.hbs');
            });
        });

        this.post('#/login', function (ctx) {
            let username = ctx.params.username;
            let password = ctx.params.password;

            auth.login(username, password)
                .then(function (userInfo) {
                    auth.saveSession(userInfo);
                    auth.showInfo('Login successful');
                    displayHome(ctx);
                }).catch(auth.handleError);
        });

        //LOGOUT
        this.get('#/logout', function (ctx) {
            auth.logout()
                .then(function () {
                    sessionStorage.clear();
                    auth.showInfo('Logged out');
                    displayHome(ctx);
                });
        });

        //REGISTER
        this.get('#/register', function (ctx) {
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                notifications: './templates/common/notifications.hbs',
                page: './templates/registerPage.hbs'
            }).then(function () {
                this.partial('./templates/main.hbs');
            });
        });

        this.post('#/register', function (ctx) {
            let username = ctx.params.username;
            let password = ctx.params.password;
            let name = ctx.params.name;

            auth.register(username, password, name)
                .then(function (userInfo) {
                    auth.saveSession(userInfo);
                    auth.showInfo('Register successful');
                    displayHome(ctx);
                });
        });

        //MY MESSAGES
        this.get('#/myMessages', async function (ctx) {
            ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');
            ctx.currentUserMessages = await messages.getMessages();
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                notifications: './templates/common/notifications.hbs',
                page: './templates/my-messages.hbs'
            }).then(function () {
                this.partial('./templates/main.hbs');
            });
        });

        //SEND MESSAGE
        this.get('#/sendMessage', async function (ctx) {
            ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');
            ctx.recipients = await messages.getRecipients();
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                notifications: './templates/common/notifications.hbs',
                page: './templates/send-message.hbs'
            }).then(function () {
                this.partial('./templates/main.hbs');
            });
        });

        this.post('#/sendMessage', function (ctx) {
            messages.sendMessage()
                .then(function () {
                    auth.showInfo('Message sent')
                }).catch(auth.handleError);

        });

        //VIEW ARCHIVE
        this.get('#/archive', async function (ctx) {
            ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');
            ctx.currentSentMessages = await messages.getSentMessages();

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                notifications: './templates/common/notifications.hbs',
                page: './templates/archive.hbs'
            }).then(function () {
                this.partial('./templates/main.hbs');
            });
        });

        function displayHome(ctx) {
            ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                notifications: './templates/common/notifications.hbs',
                page: './templates/home.hbs'
            }).then(function () {
                this.partial('./templates/main.hbs');
            });
        }
    });

    app.run();
});