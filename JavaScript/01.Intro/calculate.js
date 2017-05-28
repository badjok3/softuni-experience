function calculate(args) {

    let result = 0;

    args.forEach(function(element) {
        result += Number(element);
    });
    
    let tax = result * 0.20;
    let total = result + tax;

    console.log(result);
    console.log(tax);
    console.log(total);
}