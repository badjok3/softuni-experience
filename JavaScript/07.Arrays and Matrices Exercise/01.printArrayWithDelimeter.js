function addDelimeter(args) {
    let delimeter = args[args.length - 1];
    args.pop();

    let result = '';

    for(let i = 0; i < args.length; i++) {
        if (i === 0) {
            result += args[i];
        }   else {
            result += delimeter + args[i];
        }
    }

    return result;
}