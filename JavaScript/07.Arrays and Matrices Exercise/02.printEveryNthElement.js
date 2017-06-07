function printEveryNthElement(args) {
    let elem = Number(args[args.length - 1]);
    for(let i = 0; i < args.length - 1; i+=elem) {
        console.log(args[i]);
    }
}