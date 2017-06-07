function solve(args) {
    let result = [];

    for(let i = 0; i < args.length; i++) {
        if (i % 2 === 0) {
            result.push(args[i]);
        }
    }

    console.log(result.join(' '));
}