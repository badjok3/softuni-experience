let expect = require('chai').expect;
function rgbToHexColor(red, green, blue) {
    if (!Number.isInteger(red) || (red < 0) || (red > 255))
        return undefined; // Red value is invalid
    if (!Number.isInteger(green) || (green < 0) || (green > 255))
        return undefined; // Green value is invalid
    if (!Number.isInteger(blue) || (blue < 0) || (blue > 255))
        return undefined; // Blue value is invalid
    return "#" +
        ("0" + red.toString(16).toUpperCase()).slice(-2) +
        ("0" + green.toString(16).toUpperCase()).slice(-2) +
        ("0" + blue.toString(16).toUpperCase()).slice(-2);
}

describe('RGB To Hex', function () {
   it('should return #FFFFFF for 255, 255, 255', function () {
       expect(rgbToHexColor(255, 255, 255)).to.be.equal('#FFFFFF');
   });
   it('should return #000000 for 0, 0, 0', function () {
      expect(rgbToHexColor(0, 0, 0)).to.be.equal('#000000');
   });
   it('should return undefined for -1, 255, 255', function () {
       expect(rgbToHexColor(-1, 255, 255)).to.be.equal(undefined);
   });
   it('should return undefined for 255, -255, 1',function () {
     expect(rgbToHexColor(255, -255, 1)).to.be.equal(undefined);
   });
   it('should return undefined for 55, 256, 257', function () {
       expect(rgbToHexColor(55, 256, 257)).to.be.equal(undefined);
   });
   it('should return undefined for 255, 255, -35', function () {
       expect(rgbToHexColor(255, 255, -35)).to.be.equal(undefined);
   })
});