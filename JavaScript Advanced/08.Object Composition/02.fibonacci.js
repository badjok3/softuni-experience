function fibonacci() {
    let f1 = 0;
    let f2 = 1;

    function fib() {
        [f1, f2] = [f2, f1 + f2];
        return f1;
    }
    return fib;
}


let f = fibonacci();
console.log(f());
console.log(f());
console.log(f());
console.log(f());
console.log(f());
