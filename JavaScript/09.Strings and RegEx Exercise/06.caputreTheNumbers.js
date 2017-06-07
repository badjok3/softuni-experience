function captureNumbers(text) {
    text = text.join(' ');
    let regex = /\d+/g;

    return text.match(regex).join(' ');
}

console.log(captureNumbers(['The300', 'What is that?', 'I think it�s the 3rd movie.', 'Lets watch it at 22:45']));