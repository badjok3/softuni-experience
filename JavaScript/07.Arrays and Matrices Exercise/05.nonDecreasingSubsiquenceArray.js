function extractNonDecreasingSubsequence(args) {
    let biggest = args[0];

    for (let i = 0; i < args.length; i++) {
        if (args[i] >= biggest) {
            biggest = args[i];

            console.log(args[i]);
        }
    }
}