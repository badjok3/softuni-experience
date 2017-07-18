(function () {
    String.prototype.ensureStart = function (text) {
        if(this.indexOf(text) !== 0) {
            return text + this;
        }
        return this;
    };
    String.prototype.ensureEnd = function (text) {
        if(this.indexOf(text) !== this.length - text.length) {
            return this + text;
        }
        return this;
    };
    String.prototype.isEmpty = function () {
        return this.length <= 0;
    };
    String.prototype.truncate = function (num) {
        if(num > this.length) {
            return this;
        } else {
            let params = this.split(' ');
            let result = [];
            for(let i = 0; i < params.length - 1; i++) {
                if(result.length + params[i + 1].length <= num) {
                    result.push(params[i]);
                }
            }
            result[result.length - 1] += '...';
            return result.join(' ');
        }
    }
})();

let str = 'my string';
str = str.ensureStart('hello ');
str = str.truncate(14);
str = str.truncate(8);
//str = str.truncate(4);
//str = str.truncate(2);
console.log(str);