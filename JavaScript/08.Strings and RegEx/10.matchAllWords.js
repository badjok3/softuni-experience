function matchWords(text) {
    let regex = /\w+/g;
    let result = text.match(regex);

    console.log(result.join('|'));
}