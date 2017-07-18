function processCommands(commands) {
    let commandProcessor = (function () {
        let text = '';
        return {
            append: (newText) => text += newText,
            removeStart: (count) => text = text.slice(count),
            removeEnd: (count) => text = text.substr(0, text.length - count),
            print: () => console.log(text)
    }
    })();
    for(let cmd of  commands) {
        [command, arg] = cmd.split(' ');
        commandProcessor[command](arg);
    }
}
processCommands(['append hello',
    'append again',
    'removeStart 3',
    'removeEnd 4',
    'print']
);