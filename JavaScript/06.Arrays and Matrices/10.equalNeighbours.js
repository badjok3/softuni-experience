function solve(args) {
    let counter = 0;

    for(let i = 0; i < args.length; i++) {
        for(let j = 0; j < args[i].length; j++) {
            if (i === args.length - 1) {
                if (args[i][j] === args[i][j + 1]) {
                    counter++;
                }
            } else {
                if ((args[i][j] === args[i][j + 1]) || (args[i][j] === args[i + 1][j])) {
                    counter++;
                }
            }
        }
    }

    return counter;
}

console.log(solve(
        [[2, 2, 5, 7, 4],
        [4, 0, 5, 3, 4],
        [2, 5, 5, 4, 2]]
));