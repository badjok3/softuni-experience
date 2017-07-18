function orderRectangles(allRectangles) {
    let result = [];
    for (let [width, height] of allRectangles) {
        let currentRectangle = createRectangle(width, height);
        result.push(currentRectangle);
    }
    result.sort((a, b) => a.compareTo(b));
    return result;

    function createRectangle(width, height) {
        let rect = {
            width: width,
            height: height,
            area: () => rect.width * rect.height,
            compareTo: function (other) {
                let result = other.area() - rect.area();
                return result || (other.width - rect.width);
            }
        };
        return rect;
    }
}
