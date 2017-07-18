function objectInheritance() {
    let cars = new Map();

    for(let command of arguments[0]) {
        command = command.split(' ');
        if(command[0] === 'create') {
            if(command[2]) {
                cars.set(command[1], Object.create(cars.get(command[3])));
                continue;
            }
            cars.set(command[1], {});

        } else if(command[0] === 'set') {
            cars.get(command[1])[`${command[2]}`] = command[3];
        } else {
            let currentCar = cars.get(command[1]);
            let currentResult = [];
            for(let property in currentCar) {
                currentResult.push(`${property}:${currentCar[property]}`);
            }
            console.log(currentResult.join(', '));
        }
    }
}

objectInheritance(['create c1',
    'create c2 inherit c1',
    'set c1 color red',
    'set c2 model new',
    'print c1',
    'print c2']
);