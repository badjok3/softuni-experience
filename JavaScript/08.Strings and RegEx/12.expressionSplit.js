function split(expression) {
    let elements = expression.split(/[\s.();,]+/g);

    return elements.join('\n');
}

console.log(split('let sum = 4 * 4,b = "wow";'));