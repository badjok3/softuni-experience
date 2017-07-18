function completeOrder(order) {
    let smallEngine = { power: 90, volume: 1800 };
    let normalEngine = { power: 120, volume: 2400 };
    let monsterEngine = { power: 200, volume: 3500 };
    let hatchback = {type: 'hatchback', color: order.color};
    let coupe = {type: 'coupe', color: order.color};

    let orderedCar = {
        model: order.model
    };
    if(order.power <= 90) {
        orderedCar.engine = smallEngine;
    } else if (order.power <= 120) {
        orderedCar.engine = normalEngine;
    } else {
        orderedCar.engine = monsterEngine;
    }
    orderedCar.carriage = order.carriage === 'hatchback' ? hatchback : coupe;
    orderedCar.wheels = order.wheelsize % 2 === 0 ? [order.wheelsize-1,order.wheelsize-1,order.wheelsize-1,order.wheelsize-1] :
        [order.wheelsize,order.wheelsize,order.wheelsize,order.wheelsize];
    return orderedCar;
}

console.log(completeOrder({ model: 'Opel Vectra',
    power: 110,
    color: 'grey',
    carriage: 'coupe',
    wheelsize: 17 }
));