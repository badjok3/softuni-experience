(function () {
    return class {
        constructor() {
            this.array = [];
            this.size = 0;
        }

        add(element) {
            this.array.push(element);
            this.size++;
            this.array.sort((a, b) => a - b);
        }

        remove(element) {
            if (element >= 0 && element < this.array.length) {
                this.array.splice(element, 1);
                this.size--;
            }
        }

        get(index) {
            if (index >= 0 && index < this.array.length) {
                return this.array[index];
            }
        }
    };
})();