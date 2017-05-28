function upperCase(text) {
    let words = text.split(/\W+/);
    let upper = [];

    for(let i = 0; i < words.length; i++) {
        if (words[i]) {
            upper.push(words[i].toUpperCase());
        }
    }

    console.log(upper.join(', '));
}