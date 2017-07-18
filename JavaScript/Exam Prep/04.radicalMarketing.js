function marketing(allPeople) {
    let people = new Map();

    for (let person of allPeople) {
        let checker = person.split('-');
        if (!people.has(checker[0])) {
            people.set(checker[0], []);
        }

        if (checker.length > 1) {
            if (!people.get(checker[1]).some(p => p === checker[1] && p === checker[0])) {
                if(checker[1] !== checker[0]) {
                    people.get(checker[1]).push(checker[0]);
                }
            }
        }
    }

    people = [...people].sort(sortShit);
    for(let [person, subsribers] of people) {
        console.log(person);
        for(let i = 0; i < subsribers.length; i++) {
               console.log(`${i+1}. ${subsribers[i]}`);
        }
        break;
    }

    function sortShit(a, b) {
        if (a[1].length < b[1].length) {
            return 1;
        } else if (a[1].length > b[1].length) {
            return -1;
        }

        return 0;
    }
}

marketing(['A',
    'B',
    'C',
    'D',
    'A-B',
    'B-A',
    'C-A',
    'D-A']);