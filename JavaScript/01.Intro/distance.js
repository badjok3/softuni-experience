function getDistance(x1, y1, x2, y2) {
    let pointA = {x:x1, y:y1};
    let pointB = {x:x2, y:y2};

    let distanceX = Math.abs(pointA.x - pointB.x);
    let distanceY = Math.abs(pointA.y - pointB.y);

    return distanceX + distanceY;
}