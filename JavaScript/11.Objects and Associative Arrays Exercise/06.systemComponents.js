function storeComponents(systemRegister) {
    let allSystems = new Map();

    for(let system of systemRegister) {
        let parameters = system.split(' | ');
        [systemName, component, subcomponent] = parameters;

        if(!allSystems.has(systemName)) {
            allSystems.set(systemName, new Map());
        }

        if(!allSystems.get(systemName).has(component)) {
            allSystems.get(systemName).set(component, []);
        }

        allSystems.get(systemName).get(component).push(subcomponent);
    }

    allSystems = [...allSystems].sort(sortSystems);
    let count = 0;
    for(let [systemName, componentSubcomponent] of allSystems) {
        console.log(systemName);

        //  console.log(`||${[...componentSubcomponent]}`);
        for (let i = 0; i < [...componentSubcomponent].length; i++) {
            for (let j = 0; j < [...componentSubcomponent][i].length; j++) {
                console.log(`||${[...componentSubcomponent][j]}`);
            }
        }
    }

    function sortSystems(a, b) {
        if (a[1].length > b[1].length) {
            return 1;
        } else if (a[1].length < b[1].length) {
            return -1;
        }

        if(a[0].toLowerCase() > b[0].toLowerCase()) {
            return 1
        } else if (a[0].toLowerCase() < b[0].toLowerCase()) {
            return -1;
        }

        return 0;
    }
}

storeComponents(['SULS | Main Site | Home Page',
    'SULS | Main Site | Login Page',
    'SULS | Main Site | Register Page',
    'SULS | Judge Site | Login Page',
    'SULS | Judge Site | Submittion Page',
    'Lambda | CoreA | A23',
    'SULS | Digital Site | Login Page',
    'Lambda | CoreB | B24',
    'Lambda | CoreA | A24',
    'Lambda | CoreA | A25',
    'Lambda | CoreC | C4',
    'Indice | Session | Default Storage',
    'Indice | Session | Default Security']);

