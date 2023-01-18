$(function () {

    $.ajaxSetup({ cache: false });

    $("a[data-modal]").on("click", function (e) {

        // hide dropdown if any
        $(e.target).closest('.btn-group').children('.dropdown-toggle').dropdown('toggle');
        $('#myModalContent').load(this.href, function () {
            $('#myModal').modal({
                keyboard: true
            }, 'show');
            //console.log("Cargando...");
            var forms = document.getElementsByClassName('needs-validation');
            var validation = Array.prototype.filter.call(forms, function (form) {
                //console.log("Datos");
                form.addEventListener('submit', function (event) {
                    //console.log("Datos");
                    console.log("Datos " + form.checkValidity());
                    if (form.checkValidity() === false) {
                        event.preventDefault();
                        event.stopPropagation();
                        console.log("No esta valido");
                    } else {
                        console.log("Valido todo");
                        bindForm(this);
                    }
                    form.classList.add('was-validated');
                }, false);
            });
            //bindForm(this);
        });

        return false;
    });


});


function bindForm(dialog) {
    $('form', dialog).submit(function () {
        $.ajax({
            url: this.action,
            type: this.method,
            data: $(this).serialize(),
            success: function (result) {
                if (result.success) {
                    $('#myModal').modal('hide');
                    //Refresh
                    //location.reload();
                    location.href = 'Flujo'
                } else {
                    $('#myModalContent').html(result);
                    bindForm();
                }
            }
        });
        return false;
    });
}