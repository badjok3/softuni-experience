function draw(size) {
    let length = size % 2 !== 0 ? size : size-1;
    let count = (2*size - 4) / 2;
    let middle = Math.ceil(length/2);

    for(let i = 1; i <= length; i++) {
        if(i === 1 || i === middle || i === length) {
            console.log(`+${'-'.repeat(count)}+${'-'.repeat(count)}+`);
        } else {
            console.log(`|${' '.repeat(count)}|${' '.repeat(count)}|`);
        }
    }
}

draw(5);