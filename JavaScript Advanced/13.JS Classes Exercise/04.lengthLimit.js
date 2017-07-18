class Stringer {
    constructor(text, length) {
        this.text = text;
        this.innerLength = length;
        this.innerString = text;
    }

    increase(length) {
        this.innerLength = this.innerLength + +length;
    }

    decrease(length) {
        let newTxt = '';
        if (+length < this.innerLength) {
            for (let i = 0; i < +length; i++) {
                newTxt += this.innerString[i];
                if (this.innerLength === 0) {
                    this.innerLength = 0;
                } else {
                    this.innerLength--;
                }
            }
            newTxt += '...';
        } else {
            this.innerLength = 0;
            newTxt = '...';
        }

        this.innerString = newTxt;
    }

    toString() {
       if(this.innerLength === 0) {
           return '...';
       } else if (this.innerLength >= this.text.length) {
           return this.text;
       } else {
           return this.innerString;
       }
    }
}