function printCatalouge(products) {
    products = products.sort((a, b) => a.localeCompare(b));

    console.log(products[0][0]);
    let product = products[0].split(' : ');
    console.log(`  ${product[0]}: ${product[1]}`);

    for(let i = 1; i < products.length; i++) {
     if(products[i][0] !== products[i - 1][0]) {
         console.log(products[i][0]);
     }

     let params = products[i].split(' : ');
        console.log(`  ${params[0]}: ${params[1]}`);
    }
}