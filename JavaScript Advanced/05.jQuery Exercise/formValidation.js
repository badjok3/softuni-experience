function validate() {
    let isCompany = false;
    $('#company').on('change', function () {
        if(!isCompany) {
            $('#companyInfo').attr('style', 'display: block');
            isCompany = true;
        } else {
            $('#companyInfo').attr('style', 'display: none');
            isCompany = false;
        }

    });
    $('#submit').on('click', function (ev) {
        ev.preventDefault();
        let username = $('#username');
        let email = $('#email');
        let pass = $('#password');
        let confirmPass = $('#confirm-password');
        let userRegEx = /[A-Za-z0-9]{3,20}/;
        let isValid = true;
        if (!username.val().match(userRegEx)) {
            username.css('border', '2px solid red');
            isValid = false;
        } else {
            username.css('border', 'none');
        }
        let passRegex = /\w{5,15}/;
        if (!pass.val().match(passRegex) || pass.val() !== confirmPass.val()) {
            pass.css('border', '2px solid red');
            isValid = false;
        } else {
            pass.css('border', 'none');
        }
        if (pass.val() !== confirmPass.val() || !confirmPass.val().match(passRegex)) {
            confirmPass.css('border', '2px solid red');
            isValid = false;
        } else {
            confirmPass.css('border', 'none');
        }
        let emailRegEx = /@.*\./;
        if (!email.val().match(emailRegEx)) {
            email.css('border', '2px solid red');
            isValid = false;
        } else {
            email.css('border', 'none');
        }
        if (isCompany) {
            if ($('#companyNumber').val() < 1000 || $('#companyNumber').val() > 9999) {
                $('#companyNumber').css('border', '2px solid red');
                isValid = false;
            } else {
                $('#companyNumber').css('border', 'none');
            }
        }
        if (isValid) {
            $('#valid').attr('style', 'display: block');
        } else {
            $('#valid').attr('style', 'display: none');
        }
    });
}
