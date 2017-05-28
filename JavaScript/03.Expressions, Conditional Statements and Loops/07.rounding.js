function round([number, precision]) {
    if(precision > 15) {
        precision = 15;
    }

    let str = number.toString();
    let check = str.split('.');
    let length = check[1].length;

    if(length < precision) {
        precision = length;
    }

    return number.toFixed(precision);
}