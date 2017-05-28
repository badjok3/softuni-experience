function distance3D([x, y, z, x1, y1, z1]) {
    let obj1 = {x: x, y: y, z: z};
    let obj2 = {x: x1, y: y1, z: z1};

    let distanceX = Math.pow(obj1.x - obj2.x, 2);
    let distanceY = Math.pow(obj1.y - obj2.y, 2);
    let distanceZ = Math.pow(obj1.z - obj2.z, 2);

    return Math.sqrt(distanceX + distanceY + distanceZ);
}