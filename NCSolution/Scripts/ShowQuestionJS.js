$(function () {

    // Table setup
    // ------------------------------

    // Setting datatable defaults
    $.extend($.fn.dataTable.defaults, {
        autoWidth: false,
        columnDefs: [{
            orderable: false,
            width: '100px'
        }],
        dom: '<"datatable-header"fl><"datatable-scroll"t><"datatable-footer"ip>',
        language: {
            search: '<span>Filter:</span> _INPUT_',
            lengthMenu: '<span>Show:</span> _MENU_',
            paginate: { 'first': 'First', 'last': 'Last', 'next': '&rarr;', 'previous': '&larr;' }
        },
        drawCallback: function () {
            $(this).find('tbody tr').slice(-3).find('.dropdown, .btn-group').addClass('dropup');
        },
        preDrawCallback: function () {
            $(this).find('tbody tr').slice(-3).find('.dropdown, .btn-group').removeClass('dropup');
        }

    });


});

function format(d) {
    // `d` is the original data object for the row
    return '<table class="table" cellpadding="5" cellspacing="0" border="0" style="padding-left:50px;">' +
        '<tr>' +
        '<td>Answer1 :</td>' +
        '<td>' + d.Answer1 + '</td>' +
        '</tr>' +
        '<tr>' +
        '<td>Answer2 :</td>' +
        '<td>' + d.Answer2 + '</td>' +
        '</tr>' +
        '<tr>' +
        '<td>Answer3 :</td>' +
        '<td>' + d.Answer3 + '</td>' +
        '</tr>' +
        '<tr>' +
        '<td>Answer4 :</td>' +
        '<td>' + d.Answer4 + '</td>' +
        '</tr>' +
        '</table>';
}

var filterValues = {};
$(document).ready(function () {




    var table = $("#ShowQuestionDataTable").DataTable({
        ajax: "/Admin/GetExamDataToJson",
        dataSrc: "data",
        columns: [
            {
                "className": 'details-control',
                "orderable": false,
                "data": null,
                "defaultContent": ''
            },
            { data: "QuestionsDescription" }

        ]
    });

    console.log(table);

    $('#ShowQuestionDataTable tbody').on('click', 'td.details-control', function () {
        var tr = $(this).closest('tr');
        var row = table.row(tr);
        if (row.child.isShown()) {
            // This row is already open - close it
            row.child.hide();
            tr.removeClass('shown');
        }
        else {
            // Open this row
            row.child(format(row.data())).show();
            tr.addClass('shown');
        }
    });

});
