function solve(args) {
    let leftSum = 0;
    let rightSum = 0;

    let leftCount = 0;
    let rightCount = args[0].length - 1;

    args.forEach(elem => {
            leftSum += elem[leftCount];
            rightSum += elem[rightCount];

            leftCount++;
            rightCount--;
    });

    console.log(`${leftSum} ${rightSum}`);
}

console.log(solve([[20, 40],
    [10, 60]]
));