function solve(string, letter) {
    let arr = string.split('');
    let count = 0;

    arr.forEach(function(elem) {
        if(elem == letter) {
            count++;
        }
    });

    console.log(count);
}