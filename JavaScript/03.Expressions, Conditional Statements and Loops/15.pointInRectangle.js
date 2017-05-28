function getPoint(args) {
    let [x, y, xMin, xMax, yMin, yMax] = args;
    
    if((x >= xMin && x <= xMax) && (y >= yMin && y <= yMax)) {
        console.log('inside');
    } else {
        console.log('outside');
    }
}