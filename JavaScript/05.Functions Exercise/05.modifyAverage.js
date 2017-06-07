function solve(number) {
    let arr = number.toString().split('').map(Number);
    let sum = arr.reduce((a, b) => a+b, 0);
    while (true) {
        sum = arr.reduce((a, b) => a+b, 0);
        if (Number(sum) / arr.length > 5) {
            break;
        }

        arr.push(9);
    }

    return arr.join('');
}