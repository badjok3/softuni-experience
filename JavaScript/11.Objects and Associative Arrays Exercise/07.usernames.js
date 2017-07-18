function sortUsernames(usernames) {
    let result = new Set();

    for(let username of usernames) {
        result.add(username);
    }

    result = [...result].sort(sortUsernames);

    for(let username of result) {
        console.log(username);
    }

    function sortUsernames(a, b) {
        if(a.length > b.length) {
            return 1;
        } else if (b.length > a.length) {
            return -1;
        }

        if(a > b) {
            return 1;
        } else if (b > a) {
            return -1;
        }

        return 0;
    }
}

sortUsernames(['Ashton',
    'Kutcher',
    'Ariel',
    'Lilly',
    'Keyden',
    'Aizen',
    'Billy',
    'Braston']);

