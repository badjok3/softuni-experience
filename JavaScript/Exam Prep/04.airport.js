function airport(log) {
    let towns = new Map();
    let planes = new Set();

    for(let staus of log) {
        let tokens = staus.split(' ');
        [plane, town, passengers, action] = tokens;

        if(action === 'depart') {
            if(!planes.has(plane)) {
                continue;
            } else {
                planes.delete(plane);
            }
        }
        if(action === 'land') {
            if(planes.has(plane)) {
                continue;
            } else {
                planes.add(plane);
            }
        }

        if(!towns.has(town)) {
            towns.set(town, {planes: new Set(), arrivals: 0, departures: 0});
        }
        towns.get(town).planes.add(plane);

        if(action === 'land') {
            towns.get(town).arrivals += +passengers;
        } else if (action === 'depart') {
            towns.get(town).departures += +passengers;
        }
    }

        console.log('Planes left:');
        [...planes].sort((a, b) => a.localeCompare(b)).forEach(p => console.log(`- ${p}`));


    towns = [...towns].sort((sortTowns));
    for(let town of towns) {
        console.log(town[0]);
        console.log(`Arrivals: ${town[1].arrivals}`);
        console.log(`Departures: ${town[1].departures}`);
        console.log('Planes:');
       town[1].planes =[...town[1].planes].sort((a, b) => a.localeCompare(b));
        for(let plane of town[1].planes) {
            console.log(`-- ${plane}`);
        }
    }

    function sortTowns(a, b) {
        if (a[1].arrivals < b[1].arrivals) {
            return 1;
        } else if (b[1].arrivals < a[1].arrivals) {
            return -1;
        }

        return a[0].localeCompare(b[0]);
    }
}

airport(
    [
        'RTA72 London -10 land',
        'RTA#72 Brussels -110 depart',
        'RTA7!2 Warshaw 350 land',
        'RTA72 Riga -201 depart',
        'rta72 riga -13 land',
        'rta Riga -200 depart'
    ]
);



