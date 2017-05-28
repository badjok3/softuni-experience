function multiTable(num) {
    console.log('<table border = "1">');

    let line = '<tr><th>x</th>';
    for(let i = 1; i <= num; i++) {
        line += `<th>${i}</th>`;
    }

    line += '</tr>';
    console.log(line);
    
    function createLine() {
        for(let i = 1; i <= num; i++) {
            let row = `<tr><th>${i}</th>`;

            for(let j = 1; j <= num; j++) {
                row += `<td>${i * j}</td>`;
            }

            row += '</tr>';
            console.log(row);
        }
    }

    createLine();
    console.log('</table>');
}