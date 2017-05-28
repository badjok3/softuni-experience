function cone(radius, height) {
    let volume = (Math.PI * (radius*radius) * height) / 3;
    let slant = Math.sqrt((radius*radius)+(height*height));
    let lateral = Math.PI * radius * slant;
    let base = Math.PI * (radius*radius);
    let area = lateral + base;

    console.log(volume);
    console.log(area);
}