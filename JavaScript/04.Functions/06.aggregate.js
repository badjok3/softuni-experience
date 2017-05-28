function aggregate (args) {
    let sum = 0;
    let inverse = 0;
    let concat = '';

    for(let x of args) {
        sum += x;
        inverse += 1/x;
        concat += x;
    }

    console.log(sum);
    console.log(inverse);
    console.log(concat);
}