function censor(text, args) {

    for(let i = 0; i < args.length; i++) {
        while(true) {
            text = text.replace(args[i], '-'.repeat(args[i].length));
            if (text.indexOf(args[i]) === -1) {
                break;
            }
        }
    }

    return text;
}
