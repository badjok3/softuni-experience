let expect = require("chai").expect;
function sum(arr) {
    let sum = 0;
    for (num of arr)
        sum += Number(num);
    return sum;
}

describe("sum(arr)", function() {
    it("should return 3 for [1, 2]", function() {
        expect(sum([1, 2])).to.be.equal(3);
    });
    it("should return 10 for [5, 5]", function () {
        expect(sum([5, 5])).to.be.equal(10);
    });
    it("should return 14 for [6, 8]", function () {
        expect(sum([6, 8])).to.be.equal(14);
    })
});
