let startApp = (() => {

    //NOTIFICATIONS (LOADING)
    $(document).on({
        ajaxStart: () => $('#loadingBox').show(),
        ajaxStop: () => $('#loadingBox').fadeOut()
    });

    const app = Sammy('main', function () {
        this.use('Handlebars', 'hbs');

        this.get('market.html', displayHome);

        this.get('#/home', displayHome);

        //LOGIN
        this.get('#/login', function (ctx) {
            ctx.isLogged = sessionStorage.getItem('authtoken') !== null;
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                notifications: './templates/common/notifications.hbs',
                loginForm: './templates/login/loginForm.hbs',
                page: './templates/login/loginPage.hbs'
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

        //REGISTER
        this.get('#/register', function (ctx) {
            ctx.isLogged = sessionStorage.getItem('authtoken') !== null;
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                notifications: './templates/common/notifications.hbs',
                registerForm: './templates/register/registerForm.hbs',
                page: './templates/register/registerPage.hbs'
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

        //LOGOUT
        this.get('#/logout', function (ctx) {
            auth.logout()
                .then(function () {
                    sessionStorage.clear();
                    auth.showInfo('Logged out');
                    displayHome(ctx);
                });
        });

        //VIEW SHOP
        this.get('#/shop', async function (ctx) {
            ctx.isLogged = sessionStorage.getItem('authtoken') !== null;
            ctx.user = sessionStorage.getItem('username');
            ctx.products = await market.getShopItems();
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                notifications: './templates/common/notifications.hbs',
                product: './templates/shop/product.hbs',
                page: './templates/shop/shopPage.hbs'
            }).then(function () {
                this.partial('./templates/main.hbs')
                    .then(function () {
                        $('button').click(function () {
                            let id = $(this).parent().parent().attr('data-target');
                            auth.showInfo('Purchase successful');
                            market.moveToCart(id);
                        });
                    });
            });
        });

        //VIEW CART
        this.get('#/cart', async function (ctx) {
            ctx.isLogged = sessionStorage.getItem('authtoken') !== null;
            ctx.user = sessionStorage.getItem('username');
            ctx.cartItems = await market.getCartItems();

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                notifications: './templates/common/notifications.hbs',
                cart: './templates/cart/cart.hbs',
                page: './templates/cart/cartPage.hbs'
            }).then(function () {
                this.partial('./templates/main.hbs')
                    .then(function () {
                        $('button').click(function () {
                            let id = $(this).parent().parent().attr('data-target');
                            market.deleteCartItem(id)
                                .then(function () {
                                    auth.showInfo('Purchase successfully discarded')
                                });
                            $(this).parent().parent().remove();
                        });
                    });
            });
        });

        function displayHome(ctx) {
            ctx.isLogged = sessionStorage.getItem('authtoken') !== null;
            ctx.user = sessionStorage.getItem('username');
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