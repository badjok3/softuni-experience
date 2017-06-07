function magicMatrices(args) {

    let initialSum = args[0].reduce((a, b) => a + b);

    for(let i = 0; i < args.length; i++) {
        let rowSum = 0;
        let colSum = 0;

        for(let j = 0; j < args.length; j++) {
            rowSum += args[i][j];
            colSum += args[j][i];
        }

        if (initialSum !== rowSum && initialSum !== colSum) {
            return 'false';
        }
    }

    return 'true';
}