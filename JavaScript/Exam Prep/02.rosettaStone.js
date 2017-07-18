function solve(input) {
    let rows = input.shift();

    let templateMatrix = [];
    for(let i = 0; i < rows; i++) {
        let currentRow = input[i].split(' ').map(Number);
        templateMatrix.push(currentRow);
    }

    let encodedMatrix = [];
    for(let i = rows; i < input.length; i++) {
        let currentRow = input[i].split(' ').map(Number);
        encodedMatrix.push(currentRow);
    }

    for(let encodedRow = 0; encodedRow < )
    console.log(encodedMatrix);
    console.log(templateMatrix);
}

solve([ '2',
    '59 36',
    '82 52',
    '4 18 25 19 8',
    '4 2 8 2 18',
    '23 14 22 0 22',
    '2 17 13 19 20',
    '0 9 0 22 22' ]);