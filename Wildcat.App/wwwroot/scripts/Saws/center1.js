
function UpdateShapeFromTab(newShape) {

    console.info('Update shape from tab');

    $("#ddlShape").val(newShape);

    switch (newShape) {
        case "RND":
            $("#ddlShape").html('Round <span class="caret"></span>');
            break;
        case "REC":
            $("#ddlShape").html('Rectangle <span class="caret"></span>');
            break;
        case "RCS":
            $("#ddlShape").html('Rounded Rectangle <span class="caret"></span>');
            break;
        case "CON":
            $("#ddlShape").html('Conical <span class="caret"></span>');
            break;
    }

    $("#HiddenBarShapeSelected1").val(newShape);
    $("#HiddenBarShapeSelected2").val(newShape);
}

function SendWeight(weightType) {

    console.info('Sending weight');

    $("#HiddenPieceType").val(weightType);

    var Kerf = $("#txtKerf").val();
    var CutRate = $("#txtCutRate").val();
    var DensityCorrectionFactor = $("#txtDensityCorrectionFactor").val();
    var SawCalibrationOffset = $("#txtSawCalibrationOffset").val();

    $("#HiddenKerf").val(Kerf);
    $("#HiddenCutRate").val(CutRate);
    $("#HiddenDensityCorrectionFactor").val(DensityCorrectionFactor);
    $("#HiddenSawCalibrationOffset").val(SawCalibrationOffset);

    console.info("Sent weight for " + weightType);
}

function CallMaintenance() {

    var serviceUrl = "/Saws/CallMaintenance";

    var shopNotes = $("#ShopOrderNotes").val();
    var locationCode = $("#HiddenLocation").val();
    var bladeSelected = $("#HiddenBladeSelected1").val();
    var shopOrderNumber = $("#HiddenShopOrderNumber").val();      

    console.info("Calling maintenance...");

    $.ajax({
        url: serviceUrl,
        type: "POST",
        data: { loc: locationCode, son: shopOrderNumber, bld: bladeSelected, msg: shopNotes },
        success: function (resp) {

            $("#ServerFeedback").text(resp["retval"]);
        },
        error: function (errorThrown) {
            console.info(errorThrown);
        }
    });        
}

function SubmitMultChart() {

    var serviceUrl = "/Saws/SubmitMultChart";

    var locationCode = $("#HiddenLocation").val();
    var shopOrderNumber = $("#HiddenShopOrderNumber").val();

    $.ajax({
        url: serviceUrl,
        type: "POST",
        data: { loc: locationCode, son: shopOrderNumber },
        success: function (resp) {

            $("#ServerFeedback").text(resp["retval"]);
        },
        error: function (errorThrown) {
            console.info(errorThrown);
        }
    });
}

$(document).ready(function () {

    console.info('Doc ready on center1');

    var newId = $("#HiddenBarShapeSelected2").val();

    switch (newId) {
        case "RND":
            $('#rnd').trigger("click");
            break;
        case "REC":
            $('#rec').trigger("click");
            break;
        case "RCS":
            $('#rcs').trigger("click");
            break;
        case "CON":
            $('#con').trigger("click");
            break;
    }
});