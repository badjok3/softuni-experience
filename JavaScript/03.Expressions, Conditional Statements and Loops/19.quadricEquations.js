function solve(a, b, c) {
    let discriminant = (b*b) - (4*a*c);
    if(discriminant > 0) {
        let x1 = (-b - Math.sqrt(discriminant)) / (2*a);
        let x2 = (-b + Math.sqrt(discriminant)) / (2*a);

        console.log(x1);
        console.log(x2);
    } else if ( discriminant == 0) {
        let x = -b / (2*a);

        console.log(x);
    } else {
        console.log('No');
    }
}