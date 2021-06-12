// #region LoupeGlobal

function showModal(modalContainerId, modalBodyId, id) {
    var url = $(modalContainerId).data('url');

    $.get(url, { id: id }, function (data) {
        $(modalBodyId).html(data);
        $(modalContainerId).modal('show');
    });
}

//$('#m_table_2').DataTable({
//    scrollY: '50vh',
//    scrollX: true,
//    scrollCollapse: true,
//    deferRender: true,
//    columnDefs: [
//        {
//            "targets": [5],
//            "visible": false,
//            "searchable": false
//        }
//    ]
//});



$('.PermissionsReset').click(function () {
    $.blockUI({
        message: '<div class="sk-folding-cube sk-primary"><div class="sk-cube1 sk-cube"></div><div class="sk-cube2 sk-cube"></div><div class="sk-cube4 sk-cube"></div><div class="sk-cube3 sk-cube"></div></div><h5 style="color: #444">LOADING...</h5>',
        css: {
            backgroundColor: 'transparent',
            border: '0',
            zIndex: 9999999
        },
        overlayCSS: {
            backgroundColor: '#fff',
            opacity: 0.8,
            zIndex: 9999990
        }
    });

    $.ajax({
        url: "/Loupe/Permissions",
        type: "GET",
        cache: false,
        success: function (result) {
            $.unblockUI();

            var response = JSON.parse(result);
            if (response.success) {
                $.growl.notice({
                    message: 'Permissions Refreshed'
                });
            }
            else {
                $.growl.error({
                    message: response.message
                });
            }


        },
        error: function (result) {
            $.unblockUI();

            $.growl.error({
                message: 'Permissions not refreshed, please contact admin.'
            });
        }
    });
});

// #endregion

jQuery(document).ready(function () {
    //$('#m_table_2').DataTable({
    //    scrollY: '50vh',
    //    scrollX: true,
    //    scrollCollapse: true,
    //    deferRender: true,
    //    autoWidth: true,
    //    columnDefs: [
    //        {
    //            "targets": [5],
    //            "visible": false,
    //            "searchable": false
    //        }
    //    ],
    //    "fnCreatedRow": function (nRow, aData, iDataIndex) {
    //        var tableRowData = $(nRow).children("td");
    //        var tableHeaderRows = $("#m_table_2").find("th");

    //        for (var i = 0; i < tableRowData.length; i++) {
    //            $(tableRowData[i]).wrapInner("");
    //            $(tableRowData[i]).children("div").css("overflow", "hidden");
    //            $(tableRowData[i]).children("div").css("white-space", "nowrap");
    //            $(tableRowData[i]).children("div").css("text-overflow", "ellipsis");
    //            $(tableRowData[i]).children("div").css("max-width", ($(tableHeaderRows[i]).css("width").replace("px", "") - 10) + "px");
    //        }
    //    },
    //});

});

