$(function () {

    $('.examTable').DataTable({
        columns: [
           
            { "data": "name" },
            { "data": "position" },
            { "data": "office" },
            { "data": "salary" }
        ],
        order: [[1, 'asc']]
    });


});