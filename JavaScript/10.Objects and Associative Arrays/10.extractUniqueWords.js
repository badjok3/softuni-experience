function extractUniqueWords(text) {
    let words = new Set();
    text.forEach(line => {
        line = line.toLowerCase().split(/\W+/).filter(s=> s !== '');
        line.forEach(word => {
                words.add(word);
        });
    });

    console.log([...words.values()].join(', '));
}

console.log(extractUniqueWords(['Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque quis hendrerit dui.',
    'Quisque fringilla est urna, vitae efficitur urna vestibulum fringilla.']));