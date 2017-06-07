function solve(args) {
    let biggest = Number.MIN_SAFE_INTEGER;
    args.forEach(elem => {
        elem.forEach(e => {
            if (e > biggest) {
                biggest = e;
            }
        });
    });

    return biggest;
}