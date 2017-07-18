class Rat {
    constructor(name) {
        this.name = name;
        this.unitedRats = [];
    }
    unite(rat) {
        if(typeof rat !== 'object') {
            return;
        }
        rat.name = '##' + rat.name;
        this.unitedRats.push(rat);
    }
    getRats() {
        return this.unitedRats;
    }
    toString() {
        return this.name + ' ' + this.unitedRats.join(' ');
    }
}

let test = new Rat('Pesho');
console.log(test.toString());
console.log(test.getRats());
test.unite(new Rat('Gosho'));
test.unite(new Rat('Sasho'));
console.log(test.getRats());
console.log(test.toString());