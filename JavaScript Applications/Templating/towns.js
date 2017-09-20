function attachEvents() {
    let template = Handlebars.compile($('#towns-template').html());

    $('#btnLoadTowns').on('click', function () {
        $('#root').text('');
        let towns = $('#towns').val().split(', ');
        $('#towns').val('');

        for (let town of towns) {
            let currentTown = {town: town};
            let html = template(currentTown);
            $('#root').append(html);
        }


    });
}