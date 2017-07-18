function makeCard(face, suit) {
    let validFaces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    let validSuits = {D: '\u2666',
        C:'\u2663',
        S:'\u2660',
        H:'\u2665'};
    let card;
    if(validFaces.some(f => f === face)) {
        if(validSuits.hasOwnProperty(suit)) {
            card = face + validSuits[suit];
        } else {
            throw new Error('Error');
        }
    } else {
        throw new Error('Error');
    }
    return card;
}

console.log('' + makeCard('A', 'S'));
console.log('' + makeCard('10', 'H'));
console.log('' + makeCard('1', 'C'));