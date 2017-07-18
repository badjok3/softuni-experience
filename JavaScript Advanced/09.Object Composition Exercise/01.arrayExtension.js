let result = (function arrayExtension() {
    Array.prototype.last = function () {
        return this[this.length - 1];
    };
    Array.prototype.skip = function (number) {
        let result = [];
        for(let i = number; i < this.length; i++) {
            result.push(this[i]);
        }
        return result;
    };
    Array.prototype.take = function (number) {
        let result = [];
        for(let i = 0; i < number; i++) {
            result.push(this[i]);
        }
        return result;
    };
    Array.prototype.sum = function () {
        let sum = 0;
        for(let i = 0; i < this.length; i++) {
            sum += this[i];
        }
        return sum;
    };
    Array.prototype.average = function() {
        return this.sum() / this.length;
    };
})();

console.log([1, 2, 3].skip(1));
console.log([1, 2, 3].take(1));