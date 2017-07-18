function argumentInfo() {
    let summary = {};
    for (let i = 0; i < arguments.length; i++) {
        let obj = arguments[i];
        let type = typeof obj;
        console.log(type + ": " + obj);

        if (!summary[type]) {
            summary[type] = 0;
        }
        summary[type]++;
    }

    let result = [];
    for (let type in summary) {
        result.push([type, summary[type]]);
    }

    result.sort(sortResult);
    for (let i = 0; i < result.length; i++) {
        console.log(result[i][0] + ' = ' + result[i][1]);

    }

    function sortResult(a, b) {
        if (a[1] > b[1]) {
            return 1;
        } else if (a[1] < b[1]) {
            return -1;
        }

        return 0;
    }
}

argumentInfo('cat', 42, function () { console.log('Hello world!'); });