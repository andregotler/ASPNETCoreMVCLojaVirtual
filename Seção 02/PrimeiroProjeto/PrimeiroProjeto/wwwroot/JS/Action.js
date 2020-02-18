$(document).ready(function () {
    $(".btn-danger").click(function (e) {
        var resultado = confirm("Realmente deseja realizar esta operação?");
        if (resultado == false) {
            e.preventDefault();
        }
    });
});
