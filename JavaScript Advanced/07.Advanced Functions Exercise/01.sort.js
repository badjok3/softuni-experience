function sort(arr, type) {
    let ascending = ((a, b) => a - b);
    let descending = ((a, b) => b - a);

    let sorting = {
        'asc': ascending,
        'desc': descending
    };

    return arr.sort(sorting[type]);
}