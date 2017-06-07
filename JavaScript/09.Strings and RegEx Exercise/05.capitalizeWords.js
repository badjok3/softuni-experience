function capitalize(words) {
    words = words.split(' ');
    let result = [];
    words.forEach(word => {
        word = word.toLowerCase();
        result.push(word.replace(word[0], word[0].toUpperCase()));
    });

    return result.join(' ');
}