document.body.innerHTML = `<body>
<div id="wrapper">
    <input type="text" class="textbox"/>
    <input type="text" class="textbox"/>
</div>
</body>`;

class Textbox {
    constructor(selector, regex) {
        this._elements = $(selector);
        this._value = $(this._elements[0]).val();
        this._invalidSymbols = regex;
        this.onInput();
    }

    onInput() {
        let that = this;
        this.elements.on('input', function () {
            let text = $(this).val();
            that.value = text;
        });
    }

    get value() {
        return this._value;
    }

    set value(value) {
        this._value = value;
        for(let el of this.elements) {
            $(el).val(value);
        }
    }

    get elements() {
        return this._elements;
    }

    isValid() {
        return !this._invalidSymbols.test(this.value);
    }
}