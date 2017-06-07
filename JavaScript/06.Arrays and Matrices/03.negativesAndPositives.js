function solve(args) {
    let result = [];

    for(let i = 0; i < args.length; i++) {
        if(args[i] < 0) {
            result.splice(0, 0, args[i]);
        } else {
            result.push(args[i]);
        }
    }

    console.log(result);
}

solve([7, -2, 8, 9]);