function townsToJSON(towns) {
    let townsArr = [];

    for(let town of towns.slice(1)) {
        [empty, townName, lat, lon] = town.split(/\s*\|\s*/);
        let townObj = {'Town': townName, 'Latitude': Number(lat), 'Longitude': Number(lon)};
        townsArr.push(townObj);
    }

    return JSON.stringify(townsArr);
}

console.log(townsToJSON(['|Town|Lat|Lng|', '|Sofia |42|23|']));