function solve(args) {
    let k = Number(args[0]);
    let first = args.slice(1, k + 1);
    let last = args.slice(args.length - k, args.length);

    console.log(first.join(' '));
    console.log(last.join(' '));
}