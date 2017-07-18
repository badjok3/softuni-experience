function countOccurances(text, word) {

    text = text.toLowerCase();
    let pattern = `\\b${word}\\b`;
    let regex = new RegExp(pattern, 'gi');
    let result = text.match(regex);
    let count = 0;

    if(result) {
        count = result.length;
    } else {
        count = 0;
    }

    console.log(count);
}

console.log(countOccurances('How do you plan on achieving that? How? How can you even think of that?', 'how'));