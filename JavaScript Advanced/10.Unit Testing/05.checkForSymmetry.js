let expect = require('chai').expect;
isSymmetric = function(arr) {
    if (!Array.isArray(arr))
        return false; // Non-arrays are non-symmetric
    let reversed = arr.slice(0).reverse(); // Clone and reverse
    for(let i = 0;i<arr.length;i++){
        if(arr[i] != reversed[i]){
            return false;
        }
    }
    return true;
};

describe('isSymmetric(arr)', function () {
    it('should return true for [2, 3, 3, 2]', function () {
        expect(isSymmetric([2, 3, 3, 2])).to.be.equal(true);
    });
    it('should return false for [5, 10, 15, 20]', function () {
        expect(isSymmetric([5, 10, 15, 20])).to.be.equal(false);
    });
    it('should return true for [0, 0, 1, 1, 0, 0]', function () {
        expect(isSymmetric([0, 0, 1, 1, 0, 0])).to.be.equal(true);
    });
    it('should return fasle for {}', function () {
        expect(isSymmetric({})).to.be.equal(false);
    });
    it('should return false for 50', function () {
        expect(isSymmetric(50)).to.be.equal(false);
    })
});