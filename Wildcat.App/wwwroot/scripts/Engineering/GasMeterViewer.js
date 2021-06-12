
//FUNCTION TO DISPLAY SELECTED ITEMS IN DROPDOWN LISTS; ALSO UPDATES CORRESPONDING HIDDEN VALUE THAT WOULD OTHERWISE
// NOT COME BACK IN THE MODEL WITH A POST

$(function () {

    $(".dropdown-menu li a").click(function () {

        $(this).parents(".dropdown").find('.btn').html($(this).text() + ' <span class="caret"></span>');

        var newId = $(this)[0].id;

        switch ($(this).parents(".dropdown").find('.btn')[0].id) {
            case "ddlFurnace":
                $("#HiddenFurnaceSelected").val(newId);
                break;
            case "ddlInterval":
                $("#HiddenIntervalSelected").val(newId);
                break;
        }
    }); 
}); 

function sleep(milliseconds)
{
    var start = new Date().getTime();

    for (var i = 0; i < 1e7; i++)
    {
        if ((new Date().getTime() - start) > milliseconds) {
            break;
        }
    }
}

function UpdateProgress() {

    var gasParameters = $('form#GasParameters').serialize();

    $.ajax({
        url: "/Engineering/GasMeter/UpdateProgress",
        data: gasParameters,
        method: 'GET',
        success: function (data) {

            $("#divProgressPartial").html(data);

            var minimumCompleteness = parseInt($("#HiddenMinimimCompleteness").val());

            if (minimumCompleteness < 100)
            {
                sleep(1000);
                UpdateProgress();
            }
        },
        error: function (err) {
            console.info(err.statusText);
        }
    });
}

function ExecuteLogRequest()
{
    var gasParameters = $('form#GasParameters').serialize();

    $.ajax({
        url: "/Engineering/GasMeter/ExecuteLogRequest",
        data: gasParameters,
        method: 'POST',
        success: function (data) {
            UpdateProgress();
        },
        error: function (err) {
            console.info(err.statusText);
        }
    });
}

$('#Button1').on('click', function (e) {

    e.preventDefault();

    ExecuteLogRequest();

    //oTable1 = $('#datatable1').dataTable({
    //    processing: true,
    //    info: false,
    //    paging: false,
    //    filter: false
    //});
});

//$(document).ready(function ()
//{

    
//});