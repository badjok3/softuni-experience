function getExtensibleObject() {
    let obj = {
        extend: function (template) {
            for (let property in template) {
                if (typeof template[property] === 'function') {
                    Object.getPrototypeOf(obj)[property] = template[property];
                } else {
                    obj[property] = template[property];
                }
            }
        }
    };

    return obj;
}

let myObj = getExtensibleObject();
let template = {
    extensionMethod: function () {
        console.log('funky func');
    },
    extensionProperty: 'op'
};

myObj.extend(template);
console.log(myObj);
console.log(Object.getPrototypeOf(myObj));
