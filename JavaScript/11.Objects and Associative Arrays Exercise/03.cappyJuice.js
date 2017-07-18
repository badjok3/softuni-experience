function storeJuice(fruits) {
    let juices = new Map();
    let store = {};
    for (let quantity of fruits) {
        let parameters = quantity.split(/\s=>\s/g);

        let fruit = parameters[0];
        let amount = Number(parameters[1]);

        if(!store.hasOwnProperty(fruit)) {
            store[fruit] = amount;
        } else {
            store[fruit] += amount;
        }

        if (store[fruit] >= 1000) {
            let bottles = Math.floor(store[fruit] / 1000);
                juices.set(fruit, bottles);
        }
    }

    for (let [fruit, amount] of juices) {
            console.log(`${fruit} => ${Math.floor(amount)}`);
    }
}

storeJuice(['Orange => 2000',
    'Peach => 1432',
    'Banana => 450',
    'Peach => 600',
    'Strawberry => 549']);