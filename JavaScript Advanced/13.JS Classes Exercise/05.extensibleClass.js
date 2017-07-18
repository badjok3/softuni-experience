(function () {
    let id = 0;
    return class Extensible {
        constructor() {
            this.id = id;
            id++;
        }
        extend(template) {
            for(let property in template) {
                if(typeof property === 'function') {
                    Object.getPrototypeOf(this)[property] = template[property];
                } else {
                    this[property] = template[property];
                }
            }
        }
    }
})();