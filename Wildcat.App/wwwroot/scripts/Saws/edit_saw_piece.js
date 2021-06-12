//FUNCTION TO DISPLAY SELECTED ITEMS IN DROPDOWN LISTS; ALSO UPDATES CORRESPONDING HIDDEN VALUE THAT WOULD OTHERWISE
// NOT COME BACK IN THE MODEL
$(function () {

    $(".dropdown-menu li a").click(function () {

        console.info('Attaching drop down list event handler');

        $(this).parents(".dropdown").find('.btn').html($(this).text() + ' <span class="caret"></span>');
        var newId = $(this)[0].id;

        console.info('new id: ' + newId);

        switch ($(this).parents(".dropdown").find('.btn')[0].id) {
            case "ddlPieceCutType":
                $("#HiddenPieceCutTypeSelected").val(newId);
                break;
            case "ddlPieceBlade":
                $("#HiddenPieceBladeSelected").val(newId);
                break;
        }
    });
});



//THIS LOADS SEPARATE FROM THE MAIN JS FILE BECAUSE IT ONLY MAKES SENSE WHEN THE PIECE EDIT SCREEN IS BEING USED

$(document).ready(function () {

    console.info('Binding button clicks');

    $('#SaveEdit').bind('click', function (e) {
        SaveMultEdit();
    });

    $('#CancelEdit').bind('click', function (e) {
        CancelMultEdit();
    });

    $('#ConfirmDelete').bind('click', function (e) {
        ConfirmMultDelete();
    });
});