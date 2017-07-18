function domSearch(target, caps) {
    let container = $(target);
    let controls = $('<div>').addClass('add-controls');
    let contolLabel = $('<label>Enter text: </label>');
    let element = $('<input>');
    element.appendTo(contolLabel);
    contolLabel.appendTo(controls);

    let addBtn = $('<a>Add</a>').attr('style', 'display: inline-block');
    addBtn.addClass('button');
    addBtn.on('click', function () {
        let elem = $(`<li>`).addClass('list-item');
        let deleteBtn = $(`<a>X</a>`).addClass('button');
        deleteBtn.on('click', function () {
            $(this).parent().remove();
        });
        deleteBtn.appendTo(elem);
        let text = $(`<strong>${element.val()}</strong>`).appendTo(elem);
        element.val('');
        elem.appendTo(items);
    });
    addBtn.appendTo(controls);
    controls.appendTo(container);

    let search = $('<div>').addClass('search-controls');
    let searchLabel = $('<label>Search:</label>');
    let srcVal = $('<input>');
    srcVal.on('change', function () {
       let searchItems = items.children();
       for(let item of searchItems) {
           if(caps) {
               if(item.children[1].textContent.indexOf(srcVal.val()) === -1) {
                   $('.list-item').attr('style', 'display: none');
               } else {
                   $('.list-item').attr('style', 'display: inline-block');
               }
           } else {
               if(item.children[1].textContent.toLowerCase().indexOf(srcVal.val().toLowerCase()) === -1) {
                   $('.list-item').attr('style', 'display: none');
               } else {
                   $('.list-item').attr('style', 'display: inline-block');
               }
           }
       }
    });
    srcVal.appendTo(searchLabel);
    searchLabel.appendTo(search);
    search.appendTo(container);

    let result = $('<div>').addClass('result-controls');
    let items = $('<ul>').addClass('items-list');
    items.appendTo(result);
    result.appendTo(container);
}