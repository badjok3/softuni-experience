function calculator(a, b, op) {

    let sum = (a, b) => { return a + b };
    let subst = (a, b) => { return a - b };
    let multiply = (a, b) => { return a * b };
    let divide = (a, b) => { return a / b};

    function calc() {
        switch(op) {
            case '+': console.log(sum(a, b)); break;
            case '-': console.log(subst(a, b)); break;
            case '*': console.log(multiply(a, b)); break;
            case '/': console.log(divide(a, b)); break;
        }
    }

    calc();
}