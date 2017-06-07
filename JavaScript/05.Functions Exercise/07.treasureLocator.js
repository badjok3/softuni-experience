function solve(args) {
    for(let i = 0; i < args.length; i+=2) {
        console.log(getLocation(args[i], args[i + 1]));
    }

    function getLocation(x, y) {
        if ((x > 0 && x < 4) && (y > 0 && y < 4)) {
                return 'Tuvalu';
        } else if ((x >= 0 && x < 3) && (y > 5 && y < 9)){
                return 'Tonga';
        } else if ((x > 7 && x < 10) && (y >= 0 && y <= 1)) {
                return 'Tokelau';
        } else if ((x > 4 && x < 8) && (y > 2 && y < 7)) {
                return 'Samoa';
        } else if ((x > 3 && x < 10) && (y >= 7 && y <= 8)) {
                return 'Cook';
        }

            return 'On the bottom of the ocean';
    }
}