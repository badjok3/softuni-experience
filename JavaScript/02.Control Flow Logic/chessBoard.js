function chessBoard(size) {
    console.log('<div class="chessboard">');

    let next = 'black';

    for(let i = 0; i < size; i++) {
        console.log('<div>');

        for(let j = 0; j < size; j++) {
            if(next == 'black') {
                console.log('<span class="black"></span>');
                next = 'white';
            } else {
                console.log('<span class="white"></span>');
                next = 'black';
            }
        }

         if(i % 2 == 0) {
            next = 'white';
          } else {
            next = 'black';
        }

        console.log('</div>');
    }

    console.log('</div>');
}