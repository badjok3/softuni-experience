function extract(id) {
    let text = document.getElementById(id).textContent;
    let start = text.indexOf('(');
    let end = text.indexOf(')', start);
    let result = [];

    while (start !== -1) {
        result.push(text.substring(start, end));
        start = text.indexOf('(', end);
        end = text.indexOf(')', start+1);
    }

    return result.join('; ');
}