$(() => {
    const app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs');
        this.get('index.html', displayHome);
        this.get('#/home', displayHome);

        //ABOUT
        this.get('#/about', function (ctx) {
            ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');
            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs'
            }).then(function () {
                this.partial('./templates/about/about.hbs');
            });
        });

        //LOGIN
        this.get('#/login', function () {
            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                loginForm: './templates/login/loginForm.hbs'
            }).then(function () {
                this.partial('./templates/login/loginPage.hbs');
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
                    auth.showInfo('Logout successful');
                    displayHome(ctx);
                });
        });

        //REGISTER
        this.get('#/register', function () {
            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                registerForm: './templates/register/registerForm.hbs'
            }).then(function () {
                this.partial('./templates/register/registerpage.hbs')
            });
        });

        this.post('#/register', function (ctx) {
            let username = ctx.params.username;
            let password = ctx.params.password;
            let repeatPassword = ctx.params.repeatPassword;
            auth.register(username, password, repeatPassword)
                .then(function (userInfo) {
                    auth.saveSession(userInfo);
                    auth.showInfo('Register successful');
                    displayHome(ctx);
                }).catch(auth.handleError);
        });

        //CATALOG
        this.get('#/catalog', displayCatalog);

        //CREATE TEAM
        this.get('#/create', function (ctx) {
            ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                createForm: './templates/create/createForm.hbs',
            }).then(function () {
                this.partial('./templates/create/createPage.hbs');
            });
        });

        this.post('#/create', function (ctx) {
            let teamName = ctx.params.name;
            let teamComment = ctx.params.comment;

            teamsService.createTeam(teamName, teamComment)
                .then(function (teamInfo) {
                    teamsService.joinTeam(teamInfo._id)
                        .then(function (userInfo) {
                            auth.saveSession(userInfo);
                            auth.showInfo(`Team ${teamName} successfully created`);
                            displayCatalog(ctx);
                        }).catch(auth.handleError);
                }).catch(auth.handleError);
        });

        //TEAM DETAILS
        this.get('#/catalog/:id', async function (ctx) {
            let id = ctx.params.id.substr(1,);
            let team = await teamsService.loadTeamDetails(id);

            ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');
            ctx.name = team.name;
            ctx.comment = team.comment;
            ctx.teamId = team._id;
            ctx.isAuthor = team._acl.creator === sessionStorage.getItem('userId');
            ctx.isOnTeam = team._id === sessionStorage.getItem('teamId');
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                teamControls: './templates/catalog/teamControls.hbs'
            }).then(function () {
                this.partial('./templates/catalog/details.hbs');
            });
        });

        //JOIN TEAM (BY ID)
        this.get('#/join/:id', function (ctx) {
            let id = ctx.params.id.substr(1);

            teamsService.joinTeam(id)
                .then(function (userInfo) {
                    auth.saveSession(userInfo);
                    auth.showInfo('Team joined successfully');
                    displayCatalog(ctx);
                }).catch(auth.handleError);
        });

        //LEAVE TEAM (BY ID)
        this.get('#/leave', function (ctx) {
            teamsService.leaveTeam()
                .then(function (userInfo) {
                    auth.saveSession(userInfo);
                    auth.showInfo('Successfully left the team');
                    displayCatalog(ctx);
                });
        });

        //EDIT TEAM
        this.get('#/edit/:id', function (ctx) {
            let id = ctx.params.id;
            let team = teamsService.loadTeamDetails(id);

            ctx.name = team.name;
            ctx.comment = team.comment;
            ctx.teamId = id;
            
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                editForm: './templates/edit/editForm.hbs'
            }).then(function () {
                this.partial('./templates/edit/editPage.hbs');
            });
        });
        
        this.post('#/edit/:id', function (ctx) {
            let id = ctx.params.id.substr(2);
            let teamName = ctx.params.name;
            let teamComment = ctx.params.comment;
            console.log(ctx);
            teamsService.edit(id, teamName, teamComment)
                .then(function () {
                    auth.showInfo(`Team ${teamName} successfully updated`);
                    displayCatalog(ctx);
                }).catch(auth.handleError);
        });

        async function displayCatalog(ctx) {
            ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');
            ctx.hasNoTeam = sessionStorage.getItem('teamId') === null
                || sessionStorage.getItem('teamId') === 'undefined';
            ctx.teams = await teamsService.loadTeams();

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                team: './templates/catalog/team.hbs',
            }).then(function () {
                this.partial('./templates/catalog/teamCatalog.hbs');
            });
        }

        function displayHome(ctx) {
            ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
            ctx.username = sessionStorage.getItem('username');
            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs'
            }).then(function () {
                this.partial('./templates/home/home.hbs');
            });
        }
    });

    app.run();
});