function convertToHTML(score) {
    score = JSON.parse(score);
    let html = '<table>\n';
    html += '<tr><th>name</th><th>score</th></tr>\n';

    for(let object of score) {
        html += `<tr><td>${htmlEscape(object['name'])}</td><td>${htmlEscape(object['score'])}</td></tr>\n`;
    }

    function htmlEscape(str) {
           return str.toString()
                .replace(/&/g, '&amp;')
                .replace(/</g, '&lt;')
                .replace(/>/g, '&gt;')
                .replace(/"/g, '&quot;')
                .replace(/'/g, '&#39;');
        }


    return html + '</table>';
}