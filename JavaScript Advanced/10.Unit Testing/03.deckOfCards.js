function printDeckOfCards(cards) {
    function makeCard(face, suit) {
        let validFaces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
        let validSuits = {D: '\u2666',
            C:'\u2663',
            S:'\u2660',
            H:'\u2665'};
        let card = '';
        if(validFaces.some(f => f === face) && validSuits.hasOwnProperty(suit)) {
                card = face + validSuits[suit];
        } else {
            card = `Invalid card: ${face}${suit}`;
        }
        return card;
    }

    let result = [];
    for(let card of cards) {
        let suit = card[card.length - 1];
        let face = card.slice(0, card.length - 1);
        let currentCard = makeCard(face, suit);
        result.push(makeCard(face, suit));
    }
    if(result.some(r => r.length > 3)) {
        console.log(result.find(c => c.length > 3));
    } else {
        console.log(result.join(' '));
    }
}

printDeckOfCards(['AS', '10D', 'KH', '2C']);
printDeckOfCards(['5S', '3D', 'QD', '1C']);
printDeckOfCards(['3D', 'JC', '2S', '10H', '5X']);