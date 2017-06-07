function solve(args) {
    [x1, y1, x2, y2] = args;

    function validtyChecker(x1, y1, x2, y2) {
        let deltaX = x2 - x1;
        let deltaY = y2 - y1;
        let distance = Math.sqrt(deltaX * deltaX + deltaY * deltaY);

        if(distance % 1 === 0) {
            console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
        } else {
            console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
        }
    }

    validtyChecker(x1, y1, 0, 0);
    validtyChecker(x2, y2, 0, 0);
    validtyChecker(x1, y1, x2, y2);
}