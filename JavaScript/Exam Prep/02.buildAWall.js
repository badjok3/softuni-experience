function buildAWall(input) {
    let walls = [];
    let result = [];

    for(let param of input) {
        walls.push(Number(param));
    }


    while (walls.some(w=> w < 30)) {
        let concrete = 0;
        for(let i = 0; i < walls.length; i++) {
            if(walls[i] < 30) {
                walls[i]++;
                concrete += 195;
            }
        }
        result.push(concrete);
    }

    console.log(result.join(', '));
    console.log(`${result.reduce((a, b) => a + b)*1900} pesos`);
}

buildAWall(['0']);