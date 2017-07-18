function solve(args) {
    let count = 0;
    let biggest = Number.MIN_SAFE_INTEGER;

    for(let i = 0; i < args.length; i++) {
        if(args[i].length === 1) {
            let number = Number(args[i]);
            let currentCount = i + 1;
            let currentBiggest = 1;
            while (true) {
                if(count === number) {
                    count = 0;
                    break;
                }

                currentBiggest *= args[currentCount];
                count++;
                currentCount++;
            }

            if (currentBiggest > biggest) {
                biggest = currentBiggest;
            }
        }
    }

    return biggest;
}

console.log(solve(['18',
    '42',
    '19',
    '36',
    '1',
    '-297',
    '38',
    '100',
    '9',
    '-249',
    '-170',
    '-18',
    '-208',
    '-11',
    '-87',
    '-90',
    '-286',
    '-27']));

