function triangleArea(a, b, c) {
    let s = (a + b + c) / 2;
    let area = s * (s - a) * (s - b) * (s - c);

    return Math.sqrt(area);
}