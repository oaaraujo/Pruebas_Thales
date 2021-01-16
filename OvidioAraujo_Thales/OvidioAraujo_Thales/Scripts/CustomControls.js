


    $(".MontoMask").mask("#.##0", { reverse: true });
    $(".SoloLetrasyNumeros").mask("A", {
        'translation': {
            A: { pattern: /[A-Za-z0-9]/ }
        }        
    });
    $(".SoloNumeros").mask('#', {'translation': {  Y: { pattern: /[0-9]/ }}});
  
    $(".CuentaMask").mask("9999999999999999", { placeholder: "________________",reverse: true });
    $(".CustomDatepicker").datepicker({
        dateFormat: "dd/mm/yy",
        changeMonth: true,
        changeYear: true
    });

    $(".SoloLetrasyNumerosUTF850").mask("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", {
        'translation': {
            A: { pattern: /[A-Za-z0-9\s]*[^ñáéíóúÁÉÍÓÚÑÀÈÌÒÙàèìòù`´ÄËÏÖÜäëïöü¨]/ }
        }        
    });

    $(".SoloLetrasyNumerosUTF8100").mask("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", {
        'translation': {
            A: { pattern: /[A-Za-z0-9\s]*[^ñáéíóúÁÉÍÓÚÑÀÈÌÒÙàèìòù`´ÄËÏÖÜäëïöü¨]/ }
        }
    });

   

    $(".TablaJQuery").DataTable({
        "deferRender": true,
        "Processing": true,
        "ServerSide": true,
        "language": {
            "lengthMenu": "Mostrar _MENU_ registros por página",
            "zeroRecords": "No se encontraron datos",
            "info": "Mostrando página _PAGE_ de _PAGES_",
            "infoEmpty": "No hay registros",
            "search": "Buscar:",
            "infoFiltered": "(Filtrados de _MAX_ registros totales)",
            "paginate": {
                "first": "Primero",
                "last": "Ultimo",
                "next": "Siguiente",
                "previous": "Anterior"
            }
        },
        "cell-border": true,
        "sScrollY": "500px",
        "hover": true,
        "bScrollCollapse": true,
        "bJQueryUI": true,
        "aoColumnDefs": [
            { "sWidth": "10%", "aTargets": [-1] }
        ],
        select: true
    });




    $(".TablaFirmas").DataTable({
        "deferRender": true,
        "Processing": true,
        "ServerSide": true,
        "language": {
            "lengthMenu": "Mostrar _MENU_ registros por página",
            "zeroRecords": "No se encontraron datos",
            "info": "Mostrando página _PAGE_ de _PAGES_",
            "infoEmpty": "No hay registros",
            "search": "Buscar:",
            "infoFiltered": "(Filtrados de _MAX_ registros totales)",
            "paginate": {
                "first": "Primero",
                "last": "Ultimo",
                "next": "Siguiente",
                "previous": "Anterior"
            }
        },
        "lengthMenu": [[6, 12, 20, -1], [6, 12, 20, "Todos"]],
        "cell-border": true,
        "sScrollY": "600px",
        "hover": true,
        "select": false,
        "bScrollCollapse": true,
        "ordering": false,
        //"order": [[1, 'asc']],
        "colReorder": {
            realtime: false,
        },
        "autoWidth": false,

    });





});





function CargarDatatable(tabla) {
    
    if (!$.fn.DataTable.isDataTable("#" + tabla)) {
        var tabla = $("#" + tabla).DataTable({
            "deferRender": true,
            "Processing": true,
            "ServerSide": true,
            "language": {
                "lengthMenu": "Mostrar _MENU_ registros por página",
                "zeroRecords": "No se encontraron datos",
                "info": "Mostrando página _PAGE_ de _PAGES_",
                "infoEmpty": "No hay registros",
                "search": "Buscar:",
                "infoFiltered": "(Filtrados de _MAX_ registros totales)",
                "paginate": {
                    "first": "First",
                    "last": "Last",
                    "next": "Next",
                    "previous": "Previous"
                }
            },

            dom: 'Bfrltip',            
            "cell-border": true,
            "sScrollY": "500px",
            "autoWidth": true,
            "hover": true,
            "bScrollCollapse": true,
            "bJQueryUI": true,
            "aoColumnDefs": [
                { "sWidth": "10%", "aTargets": [-1] }
            ],
            select: false
        });
        return tabla;
    }
    return null;
}