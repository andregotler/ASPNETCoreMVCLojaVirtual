$(document).ready(function () {
    $(".btn-danger").click(function (e) {
        var resultado = confirm("Realmente deseja excluir este registro?");
        if (resultado == false) {
            e.preventDefault();
        }
    });
});
