function countWords(text) {
    let words = {};
    for(let i = 0; i < text.length; i++) {

    }
    text = text.join('').split(/\W+/g).filter(s=> s !== '');

    text.forEach(word => {
        if(!Object.keys(words).some(w => w === word)) {
            words[`${word}`] = 0;
        }
            words[`${word}`] += 1;
    });

    return JSON.stringify(words);
}