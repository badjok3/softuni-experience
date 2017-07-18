let expect = require('chai').expect;

function isOddOrEven(string) {
    if (typeof(string) !== 'string') {
        return undefined;
    }
    if (string.length % 2 === 0) {
        return "even";
    }

    return "odd";
}

describe('The length of the universe', function () {
    it('should equal even for "nai-golqmata typnq"', function () {
       expect(isOddOrEven('nai-golqmata typnq')).to.be.equal('even');
    });
    it('should equal odd for "If I wasn\'t a pirate I would\'ve bought Acid Rap"', function () {
        expect(isOddOrEven('If I wasn\'t a pirate I would\'ve bought Acid Rap')).to.be.equal('odd');
    });
    // it('should return undefined for 255', function () {
    //     expect(isOddOrEven(255)).to.be.equal('undefined',
    //     'Function did not return the correct result!');
    // });
    it('should return undefined for [255,0,0]', function () {
        expect(isOddOrEven([255, 0, 0])).to.be.equal(undefined,
        'Function did not return the correct result!');
    });
});