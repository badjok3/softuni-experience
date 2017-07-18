function subSum(arr, startIndex, endIndex) {
    let sum = 0;
    if(startIndex < 0) {
        startIndex = 0;
    }
    if(endIndex >= arr.length) {
        endIndex = arr.length - 1;
    }

    for(let i = startIndex; i <= endIndex; i++) {

            sum += +arr[i];

    }
    return +sum.toFixed(1);
}

console.log(subSum([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1));
console.log(subSum({}, 0, 2));
console.log(subSum([], 0, 0));