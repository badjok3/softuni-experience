function cityMarkets(cities) {
    let prevCity = [0][0];

    for(let city of cities) {
        let parameters = city.split(' -> ');
        let currentCity = parameters[0];
        let product = parameters[1];
        let income = parameters[2].split(':');
        let totalIncome = Number(income[0]) * Number(income[1]);

        if(currentCity !== prevCity) {
            console.log(`Town - ${currentCity}`);
        }

        prevCity = currentCity;
        console.log(`$$$${product} : ${totalIncome}`);
    }
}

cityMarkets(['Sofia -> Laptops HP -> 200 : 2000',
'Sofia -> Raspberry -> 200000 : 1500',
'Sofia -> Audi Q7 -> 200 : 100000',
'Montana -> Portokals -> 200000 : 1',
'Montana -> Qgodas -> 20000 : 0.2',
'Montana -> Chereshas -> 1000 : 0.3']);