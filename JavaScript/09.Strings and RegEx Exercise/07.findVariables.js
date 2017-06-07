function findVariables(text) {
    let regex = /\b_[A-Za-z0-9]+\b/g;
    let matches = text.match(regex);

    let result = [];
    for(let vars of matches) {
        result.push(vars.replace('_', ''));
    }

    return result.join(',');
}