function getPeople() {
    class Person {
        constructor(firstName, lastName, age, email) {
            if(firstName) {
                this.firstName = firstName;
            }
            if(lastName) {
                this.lastName = lastName;
            }
            if(age) {
                this.age = age;
            }
            if(email) {
                this.email = email;
            }
        }
        toString() {
            return `${this.firstName} ${this.lastName} (age: ${this.age}, email: ${this.email})`;
        }
    }
    let people = [];

    people.push(new Person('Maria', 'Petrova', 22, 'mp@yahoo.com'));
    people.push(new Person('SoftUni'));
    people.push(new Person('Stephan', 'Nikolov', 25));
    people.push(new Person('Peter', 'Kolev', 24, 'ptr@gmail.com'));
    return people;
}

console.log(getPeople().toString());

