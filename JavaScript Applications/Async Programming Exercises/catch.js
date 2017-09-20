function attachEvents() {
    const baseUrl = `https://baas.kinvey.com/appdata/kid_ByXMIi7U-/biggestCatches/`;
    const authHeader = {
        'Authorization': `Basic ` + btoa(`fisher:pass`),
        'Content-type': 'application/json'
    };

    $("#addForm button").click(addCatch);
    $("#aside .load").click(viewCatches);
    $(".update").click(updateCatch);
    $(".delete").click(deleteCatch);

    function addCatch() {

        let data = {
            angler: $("#addForm .angler").val(),
            weight: $("#addForm .weight").val(),
            species: $("#addForm .species").val(),
            location: $("#addForm .location").val(),
            bait: $("#addForm .bait").val(),
            captureTime: $("#addForm .captureTime").val()
        };
        console.log(data);
        $("#addForm .angler").val('');
        $("#addForm .weight").val('');
        $("#addForm .species").val('');
        $("#addForm .location").val('');
        $("#addForm .bait").val('');
        $("#addForm .captureTime").val('');

        $.ajax({
            method: "POST",
            url: baseUrl,
            headers: authHeader,
            data: JSON.stringify(data),
            success: showSuccess,
            error: handleError
        });
    }

    function viewCatches() {
        $.ajax({
            method: 'GET',
            url: baseUrl,
            headers: authHeader,
            success: getCatches,
            error: handleError
        });

        function getCatches(allCatches) {
            $("#catches").empty();
            for (let currentCatch in allCatches) {
                loadCatch(allCatches[currentCatch]);
            }
        }
    }

    function loadCatch(currentCatch) {
        let thisCatch = $("<div>").addClass('catch').attr('data-id', currentCatch._id);
        thisCatch.append($("<label>").text('Angler'));
        thisCatch.append($("<input>").attr('type', 'text').addClass('angler').attr('value', currentCatch.angler));

        thisCatch.append($("<label>").text('Weight'));
        thisCatch.append($("<input>").attr('type', 'number').addClass('weight').attr('value', currentCatch.weight));

        thisCatch.append($("<label>").text('Species'));
        thisCatch.append($("<input>").attr('type', 'text').addClass('species').attr('value', currentCatch.species));

        thisCatch.append($("<label>").text('Location'));
        thisCatch.append($("<input>").attr('type', 'text').addClass('location').attr('value', currentCatch.location));

        thisCatch.append($("<label>").text('Bait'));
        thisCatch.append($("<input>").attr('type', 'text').addClass('bait').attr('value', currentCatch.bait));

        thisCatch.append($("<label>").text('Capture Time'));
        thisCatch.append($("<input>").attr('type', 'number').addClass('captureTime').attr('value', currentCatch.captureTime));

        thisCatch.append($("<button>").addClass('update').text('Update').click(updateCatch));
        thisCatch.append($("<button>").addClass('delete').text('Delete').click(deleteCatch));

        $("#catches").append(thisCatch);
    }

    function updateCatch() {
        let currentCatch = $(this).parent()[0];
        let currentId = $(currentCatch)[0].attributes[1].value;

        $.ajax({
            method: "GET",
            url: baseUrl + currentId,
            headers: authHeader,
            success: update,
            error: handleError
        });

        function update(book) {
            let angler = book.angler;
            let weight = book.weight;
            let species = book.species;
            let location = book.location;
            let bait = book.bait;
            let captureTime = book.captureTime;

            let data = {
                'angler': `${angler}`,
                'weight': `${weight}`,
                'species': `${species}`,
                'location': `${location}`,
                'bait': `${bait}`,
                'captureTime': `${captureTime}`
            };

            $.ajax({
                method: "PUT",
                url: baseUrl + currentId,
                headers: authHeader,
                data: data,
                success: showSuccess,
                error: handleError
            });
        }
    }

    function deleteCatch() {
        console.log('deleteCatch() works');
    }

    function showSuccess() {
        alert('Your task finished successfully');
    }

    function handleError(err) {
        alert(err.status + ' ' + err.statusText);
    }
}