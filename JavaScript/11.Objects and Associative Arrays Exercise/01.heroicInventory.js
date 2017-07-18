function getInventory(heroes) {
    let allHeroes = [];

    for(let hero of heroes) {
        let stats = hero.split(' / ');
        let name = stats[0];
        let level = Number(stats[1]);
        let inventory = [];
        if(stats.length > 2) {
            inventory = stats[2].split(', ');
        }

        let currentHero = {name: name, level: level, items: inventory};

        allHeroes.push(currentHero);
    }

    return JSON.stringify(allHeroes);
}