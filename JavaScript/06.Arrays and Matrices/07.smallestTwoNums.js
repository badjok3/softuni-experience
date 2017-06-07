function solve(args) {
    args.sort((a, b) => a - b);

    console.log(args.slice(0, 2).join(' '));
}

solve([3, 0.3, -5, 25, 12]);