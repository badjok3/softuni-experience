$(() => {
    renderCatTemplate();

    function renderCatTemplate() {
        let template = Handlebars.compile($('#cat-template').html());
        $('#allCats').empty();

        for (let cat of cats) {
            let html = template(cat);
            $('#allCats').append(html);
        }

        $(`.btn-primary`).on('click', function (event) {
            let parent = $(event.target).parent().children();
            let div = parent[1];
            let button = parent[0];

            if (button.textContent.indexOf('Show') !== -1) {
                $(button).textContent = 'Hide status code';
                $(div).toggle();
            } else {
                $(button).textContent = 'Hide status code';
                $(div).toggle();
            }
        });
    }
);