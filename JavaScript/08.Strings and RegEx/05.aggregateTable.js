function aggregateTable(args) {
    let sum = 0;
    let towns = [];

    for(let i = 0; i < args.length; i++) {
        let params = args[i].split('|').filter(s=> s!== '');
        towns.push(params[0].trim());
        sum += Number(params[1]);
    }

    console.log(towns.join(', '));
    console.log(sum);
}