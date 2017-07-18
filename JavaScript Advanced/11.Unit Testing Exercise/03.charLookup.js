let expect = require('chai').expect;

function lookupChar(string, index) {
    if (typeof(string) !== 'string' || !Number.isInteger(index)) {
        return undefined;
    }
    if (string.length <= index || index < 0) {
        return "Incorrect index";
    }

    return string.charAt(index);
}

describe('lookupChar()', function () {
   it('should return "a" for (alcatraz, 0)', function () {
      expect(lookupChar('alcatraz', 0)).to.be.equal('a');
   });
    it('should return correct results for two consecutive checks', function () {
        expect(lookupChar('stranger', 7)).to.be.equal('r');
        expect(lookupChar('thaProduct', 3)).to.be.equal('P');
    });
    //valid test at random index
    it('should return "i" for ("ibibi", 2)', function () {
        expect(lookupChar('ibibi', 2)).to.be.equal('i');
    });
    //index = length
    it('should return "Incorrect index" for (getThatChinese, 15)', function () {
       expect(lookupChar('getThatChinese', 15)).to.be.equal('Incorrect index');
    });
   // wrong string input
   it('should return undefined for (["aStringyString"], 2)', function () {
       expect(lookupChar(["aStringyString"], 2)).to.be.equal(undefined);
   });
    it('should return undefined for (22, 1.3)', function () {
        expect(lookupChar('22', 1.3)).to.be.equal(undefined);
    });
   // index < string input
   it('should return "Incorrect index" for (incorrect index boiii, -3)', function () {
       expect(lookupChar('incorrect index boiii', -3)).to.be.equal('Incorrect index');
   });
   //wrong index input
   it('should return undefined for (right string, wrong index, {number: 23})', function () {
       expect(lookupChar('right string, wrong index', {number: 23})).to.be.equal(undefined);
   });
   // index > string input
   it('should return "Incorrect index" for (tryMeOut, 33)', function () {
       expect(lookupChar('tryMeOut', 33)).to.be.equal('Incorrect index');
   });
});
