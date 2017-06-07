function solve(args) {
    let arr = [];
    for(let i = args.length - 1; i > 0; i--) {
        if (i % 2 !== 0) {
            arr.push(args[i] * 2);
        }
    }

    console.log(arr.join(' '));
}

solve([10, 15, 20, 25]);