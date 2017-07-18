function elemelons() {
    class Melon {
        constructor(weight, melonSort) {
            if (new.target === Melon) {
                throw new TypeError('Abstract class cannot be instantiated directly');
            }
            this.weight = +weight;
            this.melonSort = melonSort;
            this.element = '';
            this._elementIndex = this.weight * this.melonSort.length;
        }
        get elementIndex() {
            return this._elementIndex;
        }

        toString() {
            let result = `Element: ${this.element}\n`;
            result += `Sort: ${this.melonSort}\n`;
            result += `Element Index: ${this.elementIndex}`;
            return result;
        }
    }
    class Watermelon extends Melon {

        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = 'Water';
        }
    }
    class Earthmelon extends Melon {

        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = 'Earth';
        }
    }
    class Firemelon extends Melon {

        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = 'Fire';
        }
    }
    class Airmelon extends Melon {

        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = 'Air';
        }
    }
    class Melolemonmelon extends Watermelon {
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = 'Water';
            this.elements = ['Fire', 'Earth', 'Air', 'Water'];
            this.elIndex = 0;
        }

        morph() {
            this.element = this.elements[this.elIndex++ % 4];
        }
    }

    return {
        Melon,
        Watermelon,
        Earthmelon,
        Airmelon,
        Firemelon,
        Melolemonmelon
    };
}
