function solve(req, firstName, firstAge, secondName, secondAge) {
    if(firstAge >= req) {
        console.log(`{ name: '${firstName}', age: ${firstAge} }`);
    }
    if(secondAge >= req) {
        console.log(`{ name: '${secondName}', age: ${secondAge} }`);
    }
}