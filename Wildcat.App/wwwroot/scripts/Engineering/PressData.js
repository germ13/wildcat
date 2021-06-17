
//FUNCTION TO DISPLAY SELECTED ITEMS IN DROPDOWN LISTS; ALSO UPDATES CORRESPONDING HIDDEN VALUE THAT WOULD OTHERWISE
// NOT COME BACK IN THE MODEL WITH A POST
//$(function () {

//    $(".dropdown-menu li a").click(function () {

//        console.info('Capture drop down selection');

//        $(this).parents(".dropdown").find('.btn').html($(this).text() + ' <span class="caret"></span>');

//        var newId = $(this)[0].id;

//        console.info('new id: ' + newId);

//        switch ($(this).parents(".dropdown").find('.btn')[0].id) {
//            case "ddlDuration":
//                $("#HiddenDurationSelected").val(newId);
//                break;
//            case "ddlMinValue":
//                $("#HiddenMinValueSelected").val(newId);
//                break;
//        }
//    }); 
//}); 

$(function () {

    $(".btn-group-toggle label").click(function () {

        console.info('Capture listbox selection');

        var newId = $(this)[0].firstChild.id;

        console.info('new id: ' + newId);

        var existingValues = $("#HiddenDatabasesSelected").val();

        console.info('existing values: ' + existingValues);

        //If value is already in list, toggle it off
        if (existingValues.indexOf(newId) !== -1)
        {
            existingValues = existingValues.replace("," + newId, "");
            existingValues = existingValues.replace(newId, "");

            //Remove leading comma if present
            if (existingValues[0] === ',')
                existingValues = existingValues.substring(1);

            $("#HiddenDatabasesSelected").val(existingValues);
        }
        else
        {
            if (existingValues === "")
                $("#HiddenDatabasesSelected").val(newId);
            else
                $("#HiddenDatabasesSelected").val(existingValues + ',' + newId);
        }

        console.info('updated values: ' + $("#HiddenDatabasesSelected").val());
    });
}); 

function sleep(milliseconds) {
    var start = new Date().getTime();
    for (var i = 0; i < 1e7; i++) {
        if ((new Date().getTime() - start) > milliseconds) {
            break;
        }
    }
}

$('#Button1').on('click', function () {
    DownloadFile();
});

function DownloadFile() {

    $.blockUI({
        message: '<div class="sk-folding-cube sk-primary"><div class="sk-cube1 sk-cube"></div><div class="sk-cube2 sk-cube"></div><div class="sk-cube4 sk-cube"></div><div class="sk-cube3 sk-cube"></div></div><h5 style="color: #444">PROCESSING...</h5>',
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
        url: "/SHCA/Engineering/PressData/Download",
        data: $('form#DownloadParameters').serialize(),
        method: 'GET',
        xhrFields: {
            responseType: 'blob'
        },
        success: function (data, status, xhr) {
            var a = document.createElement('a');
            var url = window.URL.createObjectURL(data);

            var filename = "";
            var disposition = xhr.getResponseHeader('Content-Disposition');
            if (disposition && disposition.indexOf('attachment') !== -1) {
                var filenameRegex = /filename[^;=\n]*=((['"]).*?\2|[^;\n]*)/;
                var matches = filenameRegex.exec(disposition);
                if (matches != null && matches[1]) {
                    filename = matches[1].replace(/['"]/g, '');
                }
            }

            a.href = url;
            a.download = filename;
            document.body.append(a);
            a.click();
            a.remove();
            window.URL.revokeObjectURL(url);

            $.unblockUI();

        },
        error: function (jqXHR, textStatus, errorThrown) {

            console.info(errorThrown);

            $.unblockUI();
        }
    });
}

function DefaultFirstDataSource() {

    $('.FXP').click();
    $(".btn-group-toggle label").first().addClass('active');

}

$(document).ready(function () {

    DefaultFirstDataSource();

});