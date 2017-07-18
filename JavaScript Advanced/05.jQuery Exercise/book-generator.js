function createBook(selector, title, author, isbn) {
    let bookGenerator = (function () {
        let id = 1;
        return function (selector, title, author, isbn) {
            let container = $(selector);
            let bookContainer = $('<div>');
            bookContainer.attr('id', `book${id}`);
            bookContainer.css('border', 'none');
            $(`<p>${title}</p>`).addClass('title').appendTo(bookContainer);
            $(`<p>${author}</p>`).addClass('author').appendTo(bookContainer);
            $(`<p>${isbn}</p>`).addClass('isbn').appendTo(bookContainer);
            let select = $('<button>Select</button>');
            let deselect = $('<button>Deselect</button>');

            select.on('click', function () {
                bookContainer.css('border', '2px solid blue');
            });
            deselect.on('click', function () {
                bookContainer.css('border', 'none');
            });

            select.appendTo(bookContainer);
            deselect.appendTo(bookContainer);
            bookContainer.appendTo(container);
            id++;
        }
    }());

    bookGenerator(selector, title, author, isbn);
}