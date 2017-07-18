function sumByTowns(towns) {
    let summedTowns = {};

    for(let i = 0; i < towns.length; i+=2) {
        if(!Object.keys(summedTowns).some(t=> t === towns[i])) {
            summedTowns[`${towns[i]}`] = Number(towns[i+1]);
        } else {
            summedTowns[`${towns[i]}`] += Number(towns[i+1]);
        }
    }

    return JSON.stringify(summedTowns);
}

console.log(sumByTowns(['Sofia',
    '20',
    'Varna',
    '3',
    'Sofia',
    '5',
    'Varna',
    '4']));