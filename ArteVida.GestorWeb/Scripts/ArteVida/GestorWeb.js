function PegaID() {
    return { id: $("#ID").val() };
}

function PegaAtletaID() {
    var i = $("#AtletaID").val();
    alert("PegaTitularID" + i);
    return { atletaId: i };
} // PegaAtletaID

function AtualizaGridIrmaos() {
    $("#GridIrmaos").data('kendoGrid').dataSource.read();
    $("#GridIrmaos").data('kendoGrid').refresh();
}


function FechadoTelaAtleta(e) {
    var grid = $('#GridAtleta').data("kendoGrid");
    grid.refresh();
}


function IncluirAtleta(e) {
    $.ajax(
            {
                url: '/Atleta/InserirAtleta',
                type: 'POST',
                data: {
                    Nome: $('#Nome').val(),
                
                    Pai: $('#Pai').val()
                },
                success: function (Content) {
                    //  var x = $("#propostaID").val();
                    // alert("Gravou vindo do controller: " + Content);
                    $("#atletaID").val(Content);
                    // alert("Gravou no componente: " + $("#propostaID").val());

                },
                error: function (Content) {
                    alert("Falhou: " + Content);
                }
            });
}    //  IncluirProposta





function onEditaAtleta() {

   // alert("Teste: Editar Atleta");

} //onEditaAtleta

function onGravaAtleta() {
   // alert("Teste: Gravar Atleta");

    this.read();
} //onGravaAtleta


function onRequestEndAtleta(e) {

    if (e.type == "create" || e.type == "update") {

        //   var id = 10;

        $("#GridAtleta").data("kendoGrid").dataSource.read();
        $("#GridAtleta").data("kendoGrid").dataSource.refresh();


    }

} //onRequestEndAtleta

function onError(e) {
    debugger;
    if (e.errors) {
        var msg = "";
        $.each(e.errors, function (key, value) {
            if (value.errors) {
                msg += "CAMPO: " + key + "\nERRO: " + value.errors[0] + "\n\n";
            }
        });

        alert(msg);
    }
}
