function solve(input) {
    let blades = input.filter(b => b > 9).map(Number);
    let types = [ 'blade', 'quite a blade', 'pants-scraper', 'frog-butcher', '*rap-poker'];
    let result = '<table border="1">\n' +
        '<thead>\n' +
        '<tr><th colspan="3">Blades</th></tr>\n' +
        '<tr><th>Length [cm]</th><th>Type</th><th>Application</th></tr>\n' +
        '</thead>\n' +
        '<tbody>\n';

    for(let blade of blades) {
        blade = Math.floor(blade);
        let type = blade > 20 ? 'sword' : 'dagger';
        let getType = blade % types.length === 0 ? 5 : blade % types.length;
        result += `<tr><td>${blade}</td><td>${type}</td><td>${types[getType-1]}</td></tr>\n`;
    }

    result += '</tbody>\n' +
            '</table>\n';

    return result;
}

console.log(solve(['17.8',
    '19.4',
    '13',
    '55.8',
    '126.96541651',
    '3']));