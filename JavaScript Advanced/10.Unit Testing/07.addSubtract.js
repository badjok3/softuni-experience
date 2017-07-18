let expect = require('chai').expect;

function createCalculator() {
    let value = 0;
    return {
        add: function(num) { value += Number(num); },
        subtract: function(num) { value -= Number(num); },
        get: function() { return value; }
    }
}

describe('createCalculator()', function () {
    let calc;
    beforeEach(function () {
        calc = createCalculator();
    });

   it('should equal 13 for {add 20, subtract 7', function () {
       calc.add(20);
       calc.subtract(7);
       let value = calc.get();
       expect(value).to.be.equal(13);
   });
   it('should equal 22 for {add 100, subtract, 80, add 2', function () {
      calc.add(100);
      calc.subtract(80);
      calc.add(2);
      let val = calc.get();
      expect(val).to.be.equal(22);
   });
});