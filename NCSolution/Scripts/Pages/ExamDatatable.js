$(function () {
    var dataSet = [
        ['Trident', 'Internet Explorer 4.0', 'Win 95+', '4', 'X'],
        ['Trident', 'Internet Explorer 5.0', 'Win 95+', '5', 'C'],
        ['Trident', 'Internet Explorer 5.5', 'Win 95+', '5.5', 'A'],
        ['Trident', 'Internet Explorer 6', 'Win 98+', '6', 'A'],
        ['Gecko', 'Firefox 1.0', 'Win 98+ / OSX.2+', '1.7', 'A'],
        ['Gecko', 'Firefox 1.5', 'Win 98+ / OSX.2+', '1.8', 'A'],
        ['Gecko', 'Firefox 2.0', 'Win 98+ / OSX.2+', '1.8', 'A'],
        ['Gecko', 'Firefox 3.0', 'Win 2k+ / OSX.3+', '1.9', 'A'],
        ['Gecko', 'Camino 1.0', 'OSX.2+', '1.8', 'A'],
        ['Gecko', 'Camino 1.5', 'OSX.3+', '1.8', 'A'],
        ['Webkit', 'Safari 1.2', 'OSX.3', '125.5', 'A'],
        ['Webkit', 'Safari 1.3', 'OSX.3', '312.8', 'A'],
        ['Webkit', 'Safari 2.0', 'OSX.4+', '419.3', 'A'],
        ['Presto', 'Opera 7.0', 'Win 95+ / OSX.1+', '-', 'A'],
        ['Presto', 'Opera 7.5', 'Win 95+ / OSX.2+', '-', 'A'],
        ['Misc', 'NetFront 3.1', 'Embedded devices', '-', 'C'],
        ['Misc', 'NetFront 3.4', 'Embedded devices', '-', 'A'],
        ['Misc', 'Dillo 0.8', 'Embedded devices', '-', 'X'],
        ['Misc', 'Links', 'Text only', '-', 'X']
    ];

    $('.datatable-js').dataTable({
        data: dataSet,
        columnDefs: []
    });




});