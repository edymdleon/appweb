$(function () {
    var placeholderElement = $('#ParaFormaModal');
    var modalContenido = $('#myModalContent');


    $('a, button[data-toggle="ajax-modal"]').not($(document.getElementById("noModal"))).click(function (event) {
        var url = $(this).data('url');
        var id = $(this).data('id');
        //url = url.trim();

        if (id != null)
            url = url + "/" + id;

        console.log("Datos... ");
        $.get(url).done(function (data) {
            //console.log("Agregando al mymodalcontent... ");
            $('#myModalContent').html(data);
            //console.log("agregando al paraformamodal");
            placeholderElement.html(data);
            //console.log(data);
            placeholderElement.find('.modal').modal('show');
        });
    });

    //placeholderElement.on('click', '[data-save="modal"]', function (event) {
    modalContenido.on('click', '[data-save="modal"]', function (event) {
        console.log("Guardar... ");
        event.preventDefault();

        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var dataToSend = form.serialize();


        $.post(actionUrl, dataToSend).done(function (data) {
            debugger;
            console.log(data);
            var newBody = $('.modal-body', data);
            placeholderElement.find('.modal-body').replaceWith(newBody);

            var isValid;
            var valida = newBody.find('[name="IsValid"]')
            if (valida.length == 0)
                isValid = placeholderElement.find('[name="IsValid"]').val() == 'True';
            else
                isValid = newBody.find('[name="IsValid"]').val() == 'True';
            console.log(data);
            if (isValid) {
                placeholderElement.find('.modal').modal('hide');
                location.reload();
            }
        });
    });
});