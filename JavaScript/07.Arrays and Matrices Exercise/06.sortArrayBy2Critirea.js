function sortArrayByThenBy(args) {

    args = args.sort(sortByLength);

    for(let i = 0; i < args.length; i++) {
        console.log(args[i]);
    }

    function sortByLength(a, b) {
        if (a.length > b.length) {
            return 1;
        } else if (b.length > a.length) {
            return -1;
        }

        if (a > b) {
            return 1;
        } else if (b > a) {
            return -1;
        } else {
            return 0;
        }

    }
}