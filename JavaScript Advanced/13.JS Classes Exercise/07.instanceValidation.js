class CheckingAccount {
    constructor(clientId, email, firstName, lastName) {
        let clientMatch = /[\d]+/;
        if(clientId.match(clientMatch)) {
            if(clientId.length === 6) {
                this.clientId = clientId;
            } else {
                throw new TypeError('Client ID must be a 6-digit number');
            }
        } else {
            throw new TypeError('Client ID must be a 6-digit number');
        }

        let emailMatch = /\b[A-Za-z0-9]*@([a-zA-Z]|\.)+\b/;
        if(email.match(emailMatch)) {
            this.email = email;
        } else {
            throw new TypeError('Invalid e-mail');
        }

        let nameMatch = /[A-Za-z]/;
        if(firstName.match(nameMatch)) {
            if(firstName.length >= 3 && firstName.length <= 20) {
                this.firstName = firstName;
            } else {
                throw new TypeError('First name must be between 3 and 20 characters long');
            }

        } else {
            throw new TypeError('First name must contain only Latin characters');
        }
        if(lastName.match(nameMatch)) {
            if(lastName.length >= 3 && lastName.length <= 20) {
                this.lastName = lastName;
            } else {
                throw new TypeError('Last name must be between 3 and 20 characters long');
            }
        } else {
            throw new TypeError('Last name must contain only Latin characters');
        }
    }
}
let acc = new CheckingAccount('131131', 'ivan@asdas', 'I', 'Petrov');