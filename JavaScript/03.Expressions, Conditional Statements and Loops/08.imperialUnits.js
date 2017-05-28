function imperials(number) {
    let feet = number / 12;
    let inches = number % 12;

    return `${Math.floor(feet)}'-${Math.floor(inches)}"`
}