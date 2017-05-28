function nextDay(year, month, day) {
    let date = new Date(year, month, day);
    date.setDate(date.getDate() + 1);

    let result = date.to(date);
    return result;
}