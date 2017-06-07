function solve(match, text) {
    let index = text.indexOf(match);
    let count = 0;

    while (index > -1) {
        count++;
        index = text.indexOf(match, index+1);
    }

    return count;
}
