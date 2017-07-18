function createRegister(allCars) {
    let cars = new Map();
    for (let i = 0; i < allCars.length; i++) {
        let parameters = allCars[i].split(' | ');
        let make = parameters[0];
        let model = parameters[1];
        let producedCars = Number(parameters[2]);

        if (!cars.has(make)) {
            cars.set(make, new Map());
        }

        let totalProducedCars = cars.get(make).get(model);
        if (!totalProducedCars) {
            cars.get(make).set(model, producedCars);
        } else {
            cars.get(make).set(model, totalProducedCars + producedCars);
        }
    }

    for (let [make, modelQuantity] of cars) {
        console.log(make);
        modelQuantity = [...modelQuantity];
        for (let i = 0; i < modelQuantity.length; i++) {
            console.log(`###${modelQuantity[i][0]} -> ${modelQuantity[i][1]}`);
        }
    }
}

createRegister([
    'BMW | X5 | 1000',
    'BMW | X6 | 100',
    'Citroen | C4 | 123',
    'Audi | Q7 | 1000',
    'Audi | Q6 | 100',
    'Volga | GAZ-24 | 1000000',
    'Lada | Niva | 1000000',
    'Lada | Jigula | 1000000',
    'Citroen | C4 | 22',
    'Citroen | C5 | 10']);