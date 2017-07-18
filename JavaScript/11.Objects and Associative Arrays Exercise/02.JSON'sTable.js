function printTable(people) {
    console.log('<table>');
    for(let person of people) {
        let line = '    <tr>\n';
        person = JSON.parse(person);

        line += `        <td>${person.name}</td>\n`;
        line += `        <td>${person.position}</td>\n`;
        line += `        <td>${Number(person.salary)}</td>\n`;
        line += '   <tr>';

        console.log(line);
    }
    console.log('</table>');
}