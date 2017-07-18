function encode(input) {
    let result = '';
    let key = input.shift();
    let pattern = `(^|\\s)(${key}\\s+)([A-Z!%#$]{8,})($|,|\\.|\\s)`;
    let regex = new RegExp(pattern, 'gi');

    for(let line of input) {
        let match = regex.exec(line);

        while(match) {
            let msg = '';
            if(match[3] === match[3].toUpperCase()) {
                msg = replaceTxt(match[3]);
                msg = msg.toLowerCase();
            } else {
                msg = match[3];
            }

            line = line.replace(match[0], match[1] + match[2]  + msg + match[4]);
            match = regex.exec(line);
        }

        result += line + `\n`;
    }


    return result;

    function replaceTxt(word) {
        return word
            .replace(/!/g, '1')
            .replace(/%/g, '2')
            .replace(/#/g, '3')
            .replace(/\$/g, '4');
    }
}

console.log(encode(['symbol',
    'symbol TEST!#$%, and symbol %$$!#$$% and symbol H$H$H$H$',
    'symbol FAIL!@#$ symbol )_(~*^@WOW, symbol %%%%!!##$$^',
    'symbol ano!the%rf!ai$$l%#',
    'symbol S#OME!#SU$CC$E%SS%%.',
    'lets not forget the underscore symbol WRONG_WRONG',
    'This sentence is capitalized symbol WOWZ0RZLEL',
    'LETS MIX IN LOWER LETTERS symbol NOTg0NNAWORK',]));
//symbol test1342, and symbol 24413442 and symbol h4h4h4h4
//symbol FAIL!@#$ symbol )_(~*^@WOW, symbol %%%%!!##$$^
//symbol ano!the%rf!ai$$l%#
//symbol s3ome13su4cc4e2ss22.
//lets not forget the underscore symbol WRONG_WRONG
//This sentence is capitalized symbol WOWZ0RZLEL
//LETS MIX IN LOWER LETTERS symbol NOTg0NNAWORK
