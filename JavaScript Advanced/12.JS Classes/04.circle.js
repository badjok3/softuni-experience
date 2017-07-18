class Circle {
    constructor(radius)
        {this.radius = radius;}
        get diameter() {return 2 * +this.radius};
        set diameter(diameter) {
            this.radius = diameter / 2;
        }
        get area() {
            return Math.PI * (+this.radius * +this.radius);
        }
}

let circle = new Circle(5);
circle.diamater = 1.6;
console.log(circle.radius);
console.log(circle.diameter());
console.log(circle.area());