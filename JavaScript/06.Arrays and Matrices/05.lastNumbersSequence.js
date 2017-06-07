function solve(length, k) {
    let arr = [];
    arr[0] = 1;

    let result = 0;

    for(let i = 1; i < length; i++) {
        if(k < arr.length) {
            for(let j = 0; j < k; j++) {
                result += arr[arr.length - k + j];

            }
        } else {
            result = arr.reduce((a, b) => a + b);
        }

        arr.push(result);
        result = 0;
    }

    return arr.join(' ');
}