function parseData(data) {
    let regex = /^([A-Z][a-zA-Z]*) - ([1-9]\d*) - ([A-Za-z0-9 \-]+)$/;
    let result = [];

    for(let employee of data) {
        let match = regex.exec(employee);
        if (match === null) continue;
        result.push(`Name: ${match[1]}
        Position: ${match[3]}
        Salary: ${Number(match[2])}`);
    }

    return result.join('\n');
}