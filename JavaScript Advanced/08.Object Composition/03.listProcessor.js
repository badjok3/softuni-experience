function processor() {
    let commandExecutionEngine = {
        collection: [],
        add: (text) => commandExecutionEngine.collection.push(text),
        remove: (text) => {
            for(let i = 0; i < commandExecutionEngine.collection.length; i++) {
                if(text === commandExecutionEngine.collection[i]) {
                    commandExecutionEngine.collection.splice(i, 1);
                }
            }
        },
        print: () => console.log(commandExecutionEngine.collection.join(','))
    };

    for(let action of arguments[0]) {
        action = action.split(' ');
        if(action.length > 1) {
            commandExecutionEngine[`${action[0]}`](action[1]);
        } else {
            commandExecutionEngine[`${action}`]();
        }
    }
}