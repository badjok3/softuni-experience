function sortedList() {
    return {
        array: [],
        size :0,
        add: function (element) {
                this.array.push(element);
                this.size++;
                this.array.sort((a, b) => a - b);
        },
        remove: function (element) {
            if(element >= 0 && element < this.array.length) {
                this.array.splice(element, 1);
                this.size--;
            }
        },
        get: function (index) {
            if(index >= 0 && index < this.array.length) {
                return this.array[index];
            }
        },
    };
}