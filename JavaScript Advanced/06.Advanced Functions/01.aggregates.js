function aggregates(numbers) {
    let biggest = Number.MIN_SAFE_INTEGER;
    numbers.forEach(number => {
        if (number > biggest) {
            biggest = number;
        }
    });
    return biggest;
}

console.log(aggregates([2, 3, 10, 5]));