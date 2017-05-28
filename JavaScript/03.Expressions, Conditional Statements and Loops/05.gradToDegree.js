function gradToDeg(grad) {
    let degree = (grad * 360/400) % 360;
    
    while(degree < 0) {
        degree += 360;
    }

    return degree;
}