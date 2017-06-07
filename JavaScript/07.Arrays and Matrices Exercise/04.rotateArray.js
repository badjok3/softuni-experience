function rotateArray(args) {
    let rotations = Number(args.pop() % args.length);
    let elem = '';

    for(let i = 0; i < rotations; i++) {
        elem = args.pop();
        args.unshift(elem);
    }

    return args.join(' ');
}