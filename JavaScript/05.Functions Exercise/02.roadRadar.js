function infractionChecker(args) {
    [speed, zone] = args;

    function getLimit(zone) {
        switch (zone) {
            case 'motorway': return 130;
            case 'interstate': return 90;
            case 'city': return 50;
            case 'residential': return 20;
        }
    }

    let limit = getLimit(zone);
    let diff = speed - limit;

    if (speed > limit) {
        if (diff > 40) {
            console.log('reckless driving');
        } else if (diff > 20 && diff <= 40) {
            console.log('excessive speeding');
        } else if (diff <= 20 && diff > 0) {
            console.log('speeding');
        }
    }
}
