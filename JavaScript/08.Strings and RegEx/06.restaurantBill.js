function getBill(args) {
    let items = [];
    let total = 0;

    for(let i = 0; i < args.length; i+=2) {
        items.push(args[i]);
        total += Number(args[i+1]);
    }

    console.log(`You purchased ${items.join(', ')} for a total sum of ${total}`);
}