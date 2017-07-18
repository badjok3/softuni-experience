function countWithMaps(text) {
    text = text.join('').split(/\W+/g).filter(w=> w !== '');
    let result = new Map();

    text.forEach(word => {
        if (!result.has(word.toLowerCase())) {
            result.set(`${word.toLowerCase()}`, 0);
        }
        let thisWord = result.get(word.toLowerCase());
        result.set(`${word.toLowerCase()}`, thisWord+1);
    });

    result = [...result].sort();

    for(let [key, value] of result) {
        console.log(`'${key}' -> ${value} times`);
    }
}