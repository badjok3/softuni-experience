let manager = function () {
    let robot = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    };

    let products = {
        apple: {
            carbohydrate: 1,
            flavour: 2
        },
        coke: {
            carbohydrate: 10,
            flavour: 20
        },
        burger: {
            carbohydrate: 5,
            fat: 7,
            flavour: 3
        },
        omelet: {
            protein: 5,
            fat: 1,
            flavour: 1
        },
        cheverme: {
            protein: 10,
            carbohydrate: 10,
            fat: 10,
            flavour: 10
        }
    };

    return function (inputString) {
        let args = inputString.split(' ');
        let action = args[0];
        if(action === 'restock') {
            robot[args[1]] += +args[2];
            return 'Success';

        } else if (action === 'prepare') {
            let product = args[1];
            let prooductQty = +args[2];
            let productStats = products[product];

            let productCanBeCooked = true;
            for(let microElement in productStats) {
                if(productStats.hasOwnProperty(microElement)) {
                    let microElementQuantity = productStats[microElement];
                    if(robot[microElement] < microElementQuantity * prooductQty) {
                        productCanBeCooked = false;
                        return `Error: not enough ${microElement} in stock`;
                    }
                }
            }

            if(productCanBeCooked) {
                for(let microElement in productStats) {
                    if(productStats.hasOwnProperty(microElement)) {
                        let microElementQuantity = +productStats[microElement];
                        robot[microElement] -= microElementQuantity * prooductQty;
                    }
                }
                return 'Success';
            }
        } else if (action === 'report') {
            return `protein=${robot.protein} carbohydrate=${robot.carbohydrate} fat=${robot.fat} flavour=${robot.flavour}`;
        }
    }
};

manager('prepare cheverme 1');
manager('restock protein 10');
manager('prepare cheverme 1');
manager('restock carbohydrate 10');
manager('prepare cheverme 1');
manager('restock fat 10');
manager('prepare cheverme 1');
manager('restock flavour 10');
manager('prepare cheverme 1');
manager('report');