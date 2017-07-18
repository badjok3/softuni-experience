function solve(input) {
    let yields = Number(input);
    let spices = 0;
    let days = 0;

    while (true) {
        if (yields < 100) {
            if (spices > 26) {
                spices -= 26;
            }
            break;
        }

        let currentSpices = yields;
        currentSpices -= 26;
        days++;
        yields -= 10;
        spices += currentSpices;


    }

    console.log(days);
    console.log(spices);
}

solve(['111']);