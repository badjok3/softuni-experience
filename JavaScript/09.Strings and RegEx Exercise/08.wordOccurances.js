function countOccurances(text, word) {

    let matches = text.toLowerCase().match(`^${word}$`);

    return matches;
}

console.log(countOccurances('How do you plan on achieving that? How? How can you even think of that?', 'how'));