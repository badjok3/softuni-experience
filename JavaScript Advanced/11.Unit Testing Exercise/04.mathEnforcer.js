let expect = require('chai').expect;

let mathEnforcer = {
    addFive: function (num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num + 5;
    },
    subtractTen: function (num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num - 10;
    },
    sum: function (num1, num2) {
        if (typeof(num1) !== 'number' || typeof(num2) !== 'number') {
            return undefined;
        }
        return num1 + num2;
    }
};

describe('Math Enforcer', function () {
    describe('addFive', function () {
        it('should return undefined for non-number parameter', function () {
            expect(mathEnforcer.addFive('notARealNumber')).to.be.equal(undefined);
        });
        it('should return valid result for number parameter', function () {
            expect(mathEnforcer.addFive(32)).to.be.equal(37);
        });
        it('should return valid result for negative number', function () {
            expect(mathEnforcer.addFive(-5)).to.be.equal(0);
        });
        it('should return valid result for floating point number', function () {
            expect(mathEnforcer.addFive(3.3)).to.be.equal(8.3);
        });
    });
    describe('subtractTen', function () {
       it('should return undefind for non-number parameter', function () {
           expect(mathEnforcer.subtractTen({number: 32})).to.be.equal(undefined);
       });
       it('should return a valid result for number parameter', function () {
           expect(mathEnforcer.subtractTen(54)).to.be.equal(44);
       });
        it('should return valid result for negative number', function () {
            expect(mathEnforcer.subtractTen(-5)).to.be.equal(-15);
        });
        it('should return valid result for floating point number', function () {
            expect(mathEnforcer.subtractTen(3.3)).equal(-6.7);
        });
    });
    describe('sum', function () {
        it('should return undefiend or non-number parameters', function () {
            expect(mathEnforcer.sum('notANum', 32)).to.be.equal(undefined);
            expect(mathEnforcer.sum(33, 'notANumEither')).to.be.equal(undefined);
        });
        it('should return a valid number for valid paramters', function () {
            expect(mathEnforcer.sum(32, 43)).to.be.equal(75);
        });
        it('should return valid result for negative number', function () {
            expect(mathEnforcer.sum(-5, 30)).to.be.equal(25);
        });
        it('should return valid result for floating point number', function () {
            expect(mathEnforcer.sum(3.3, 6.7)).to.be.equal(10);
        });
    });
});