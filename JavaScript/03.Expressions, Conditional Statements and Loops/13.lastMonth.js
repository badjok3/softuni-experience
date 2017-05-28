function getLastMonth([day, month, year]) {
     
     let date = new Date(year, month-1, 0);
     return date.getDate();
}

console.log(getLastMonth([13, 3, 2005]));