function getDistance([obj1, obj2, time]) {
    let distance = Math.abs(obj1 - obj2);
    let hours = time / 3600;
    let result = distance * hours * 1000;

    return result;
}