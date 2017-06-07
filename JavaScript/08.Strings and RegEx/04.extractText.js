function extractText(text) {
    let open = text.indexOf('(');

    let result = [];
    while (open !== -1) {

        let close = text.indexOf(')', open);

        if(close === -1) {
            break;
        }

        result.push(text.substring(open+1, close));
        open = text.indexOf('(', close);
    }

    return result.join(', ');
}