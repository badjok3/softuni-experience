function listTowns(towns) {
    let result = new Map();
    for(let town of towns) {
        let parameters = town.split(' <-> ');
        let city = parameters[0];
        let population = Number(parameters[1]);
        if(!result.has(city)) {
            result.set(city, population);
        } else {
            result.set(city, result.get(city) + population);
        }
    }

    for(let [city, population] of result) {
        console.log(`${city} : ${population}`);
    }
}