function extractUsernames(args) {
    let result = [];

    for(let i = 0; i < args.length; i++) {
            let params = args[i].split('@');
            let username = `${params[0]}.`;
            let extentions = params[1].split('.');

            for(let j = 0; j < extentions.length; j++) {
                username += extentions[j][0];
            }

            result.push(username);
    }

    return result.join(', ');
}