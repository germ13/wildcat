
function makeBars(barData) {

    console.info('Make bars');

    //Reset chart; sometimes we are replacing an existing chart
    $("#barDiv").html("");

    //Sequence here was chosen for maximum contrast so adjacent bars could be discerned
    var color1 = $("#colorSample1").css("background-color");
    var color2 = $("#colorSample2").css("background-color");
    var color3 = $("#colorSample3").css("background-color");
    var color4 = $("#colorSample4").css("background-color");
    var color5 = $("#colorSample5").css("background-color");
    var color6 = $("#colorSample6").css("background-color");

    var maxWidth = $('#barDiv').parent().width();

    var color = '';
    var lastBar = '';

    var barNames = [''];
    var bars = 0;
    var mults = barData.length;

    for (i = 0; i < mults; i++) {
        if (barData[i][0] !== lastBar) {
            barNames[bars] = barData[i][0];
            lastBar = barData[i][0];
            bars++;
        }

        if (bars > 5)
            i = mults;
    }

    switch (bars) {
        case 6:
            color = { [barNames[0]]: color1, [barNames[1]]: color2, [barNames[2]]: color3, [barNames[3]]: color4, [barNames[4]]: color5, [barNames[5]]: color6 };
            break;
        case 5:
            color = { [barNames[0]]: color1, [barNames[1]]: color2, [barNames[2]]: color3, [barNames[3]]: color4, [barNames[4]]: color5 };
            break;
        case 4:
            color = { [barNames[0]]: color1, [barNames[1]]: color2, [barNames[2]]: color3, [barNames[3]]: color4 };
            break;
        case 3:
            color = { [barNames[0]]: color1, [barNames[1]]: color2, [barNames[2]]: color3 };
            break;
        case 2:
            color = { [barNames[0]]: color1, [barNames[1]]: color2 };
            break;
        case 1:
        default:
            color = { [barNames[0]]: color1 };
            break;
    }

    var svg = d3.select(".barDistribution").append("svg").attr("width", maxWidth).attr("height", 400);
    var g = svg.append("g").attr("transform", "translate(0,0)");

    var bp = viz.bP()
        .data(barData)
        .min(12)
        .pad(1)
        .height(300)
        .width(maxWidth)
        .orient("horizontal")
        .barSize(35)
        .fill(d => color[d.primary]);

    g.call(bp);

    g.selectAll(".mainBars")
        .on("mouseover", mouseover)
        .on("mouseout", mouseout);

    g.selectAll(".mainBars").append("text").attr("class", "label")
        .attr("x", d => (d.part === "primary" ? 5 : -60))
        .attr("y", d => +4)
        .text(d => d.key)
        .attr("text-anchor", d => (d.part === "primary" ? "end" : "start"));

    g.selectAll(".mainBars").append("text").attr("class", "text")
        .attr("x", d => (d.part === "primary" ? 30 : 45))
        .attr("y", d => +4)
        .text(function (d) { return (d.value); })
        .attr("text-anchor", d => (d.part === "primary" ? "end" : "start"));

    d3.select(self.frameElement).style("height", "800px");

}

function mouseover(d) {

    bp.mouseover(d);
    g.selectAll(".mainBars").select(".text")
        .text(function (d) { return d.value; });
}

function mouseout(d) {

    bp.mouseout(d);
    g.selectAll(".mainBars").select(".text")
        .text(function (d) { return d.value; });
}

//FUNCTION TO REFRESH BAR DATA

function RefreshBarDistribution(locationCode, shopOrderNumber) {

    console.info('Refresh chart data');

    $.ajax({
        url: "/Planning/GetBarDistribution",
        cache: false,
        data: { loc: locationCode, son: shopOrderNumber },
        //dataType: "html",
        contentType: "json",
        success: function (response) {
            makeBars(response);

            console.info('Finished chart data');
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.info("Status: " + textStatus + "Error: " + errorThrown);
        }
    });
}

function CuttingTicketClick() {

    var shopOrderNumber = $("#discreteJobNumber").val();

    window.open('/Planning/PlanningPrintCuttingTicket/?loc=CFCA&son=' + shopOrderNumber);

}

//FUNCTION TO FETCH JOBS

$('#GetJob').on('click', function () {

    console.info('Starting new job data request');

    var shopOrderNumber = $("#discreteJobNumber").val();

    //Switching ajax to get appears to run faster and still be asynchronous
    $.get("/Planning/JobDetailPartial",
        { son: shopOrderNumber },
        function (response) {
            console.info('Phase one new job data success');
            $("#divJob").html(response);

            $.get("/Planning/MaterialCodePartial",
                { son: shopOrderNumber },
                function (response) {
                    console.info('Phase two new job data success');
                    $("#divMaterial").html(response);

                }
            );
        }
    );

    //$.ajax({
    //    url: "/Planning/JobDetailPartial",
    //    cache: false,
    //    data: { son: shopOrderNumber },
    //    dataType: "html",
    //    contentType: "json",
    //    success: function (response) {
    //        $("#divJob").html(response);

    //        console.info('Phase one new job data success');

    //$.ajax({
    //    url: "/Planning/MaterialCodePartial",
    //    cache: false,
    //    data: { son: shopOrderNumber },
    //    dataType: "html",
    //    contentType: "json",
    //    success: function (response) {

    //        $("#divMaterial").html(response);

    //        console.info('Phase two new job data success');
    //    },
    //    error: function (XMLHttpRequest, textStatus, errorThrown) {
    //        console.info("Status: " + textStatus + "Error: " + errorThrown);
    //    }
    //});
    //    },
    //    error: function (XMLHttpRequest, textStatus, errorThrown) {            
    //        console.info("Status: " + textStatus + "Error: " + errorThrown);
    //    }
    //});  

    RefreshBarDistribution("CFCA", shopOrderNumber);

});

//FUNCTION TO DISPLAY SELECTED ITEMS IN DROPDOWN LISTS

$(function () {

    $(".dropdown-menu li a").click(function () {
        $(this).parents(".dropdown").find('.btn').html($(this).text() + ' <span class="caret"></span>');
        $(this).parents(".dropdown").find('.btn').val($(this).data('value'));

        var newId = "0";

        switch ($(this).parents(".dropdown").find('.btn')[0].id) {
            case "ddlJob":
                newId = $(this)[0].id;
                window.location = '/Planning/Index/' + newId;
                break;
            case "ddlShape":
                newId = $(this)[0].id;
                $("#HiddenShapeSelected").val(newId);
                break;
            case "ddlMetal":
                newId = $(this)[0].id;
                $("#HiddenMetalSelected").val(newId);
                break;
            case "ddlTest":
                newId = $(this)[0].id;
                $("#HiddenTestCategoryOptions").val(newId);
                break;
            case "ddlUnit":
                newId = $(this)[0].id;
                $("#HiddenUnitTypeOptions").val(newId);
                break;
            //case "ddlSort":
            //    newId = $(this)[0].id;
            //    $("#HiddenSortOptions").val(newId);
            //    break;
        }

    });
});

var shopOrderNumber = $("#discreteJobNumber").val();

console.info("Job Number: " + shopOrderNumber);

//INITIAL DEFAULT POPULATION
RefreshBarDistribution("CFCA", shopOrderNumber);

//GRID1 SECTION

var oTable1 = null;
var nEditing1 = null;

function AttachEdit(oTable1, excludeRestore) {

    $('#datatable1 a.edit').on('click', function (e) {

        e.preventDefault();

        /* Get the row as a parent of the link that was clicked on */
        var nRow1 = $(this).parents('tr')[0];

        if (nEditing1 !== null && nEditing1 !== nRow1) {

            /* Currently editing - but not this row - restore the old before continuing to edit mode */
            if (!excludeRestore) {
                restoreRow(oTable1, nEditing1);

                editRow(oTable1, nRow1);
                nEditing1 = nRow1;
            }
        }
        else if (nEditing1 === nRow1 && this.innerHTML === "Save") {

            /* Editing this row and want to save it */
            saveRow(oTable1, nEditing1);
            nEditing1 = null;
        }
        else {

            /* No edit in progress - let's start one */
            editRow(oTable1, nRow1);
            nEditing1 = nRow1;
        }
    });
}

function RemoveRow1FromServer(rid) {
    $.ajax({
        type: 'POST',
        data: { RowID: rid },
        url: '/Planning/RemoveTable1Record',
        success: function (response) {
            //DELETE SUCCESS!
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.info("Status: " + textStatus + "; Error: " + errorThrown);
            //DELETE ISSUE!
        }
    });
}

function AttachDelete(oTable1) {

    $('#datatable1 a.delete').on('click', function (e) {

        e.preventDefault();

        var nRow1 = $(this).parents('tr')[0];
        //NEW
        var aData = oTable1.fnGetData(nRow1);

        switch (this.innerHTML) {
            case "Delete":
                oTable1.fnDeleteRow(nRow1);

                //NEW
                RemoveRow1FromServer(aData[0]);

                break;
            case "Cancel":
                cancelRow(oTable1, nRow1);
                nEditing1 = null;
                break;
        }
    });
}

function restoreRow(oTable1, nRow1) {

    var aData = oTable1.fnGetData(nRow1);

    if (aData === null)
        return;

    var jqTds = $('>td', nRow1);

    for (var i = 0, iLen = jqTds.length; i < iLen; i++) {
        oTable1.fnUpdate(aData[i], nRow1, i, false);
    }

    oTable1.fnDraw();
}

function cancelRow(oTable1, nRow1) {

    var aData = oTable1.fnGetData(nRow1);
    var jqTds = $('>td', nRow1);

    jqTds[0].innerHTML = aData[0];
    jqTds[1].innerHTML = aData[1];
    jqTds[2].innerHTML = aData[2];
    jqTds[3].innerHTML = aData[3];
    jqTds[4].innerHTML = aData[4];
    jqTds[5].innerHTML = aData[5];

    jqTds[6].innerHTML = jqTds[6].innerHTML.replace('>Save<', '>Edit<');
    jqTds[7].innerHTML = jqTds[7].innerHTML.replace('>Cancel<', '>Delete<');

    nEdit1 = null;

    AttachEdit(oTable1, true);
    AttachDelete(oTable1);
}

function editRow(oTable1, nRow1) {

    var aData = oTable1.fnGetData(nRow1);
    var jqTds = $('>td', nRow1);

    if (jqTds.length === 0)
        return;

    //DO NOT ALLOW RECORD ID EDIT
    //jqTds[0].innerHTML = '<input type="text" size="15px" value="' + aData[0] + '">';
    jqTds[1].innerHTML = '<input type="text" size="10px" value="' + aData[1] + '">';

    //jqTds[2].innerHTML = '<input type="text" size="20px" value="' + aData[2] + '">';
    //jqTds[3].innerHTML = '<input type="text" size="4px" value="' + aData[3] + '">';
    //jqTds[4].innerHTML = '<input type="text" size="4px" value="' + aData[4] + '">';
    //jqTds[5].innerHTML = '<input type="text" size="36px" value="' + aData[5] + '">';

    jqTds[6].innerHTML = jqTds[6].innerHTML.replace('>Edit<', '>Save<');

    //Only offer cancel if they are truly editing an existing record. 
    // Sometimes this method is called with new records, in which case,
    // delete is more appropriate than cancel...we don't want to leave
    // intact the values as read-only
    if (aData[0].length > 0)
        jqTds[7].innerHTML = jqTds[7].innerHTML.replace('>Delete<', '>Cancel<');

    AttachEdit(oTable1, true);
    AttachDelete(oTable1);
}

function saveRow(oTable1, nRow1) {

    var jqInputs = $('input', nRow1);

    oTable1.fnUpdate(jqInputs[0].value, nRow1, 1, false);
    oTable1.fnUpdate(jqInputs[1].value, nRow1, 2, false);
    //oTable1.fnUpdate(jqInputs[2].value, nRow1, 3, false);
    //oTable1.fnUpdate(jqInputs[3].value, nRow1, 4, false);
    //oTable1.fnUpdate(jqInputs[4].value, nRow1, 5, false);
    //oTable1.fnUpdate(jqInputs[5].value, nRow1, 6, false);

    oTable1.fnUpdate('<a class="edit btn btn-sm btn-outline-primary" href="#">Edit</a>', nRow1, 6, false);
    oTable1.fnUpdate('<a class="delete btn btn-sm btn-outline-secondary" href="#">Delete</a>', nRow1, 7, false);

    jqInputs = $('>td', nRow1);

    var sdt = JSON.stringify({
        "Field00": jqInputs[0].innerText,
        "Field01": jqInputs[1].innerText,
        //"Field02": jqInputs[2].innerText,
        //"Field03": jqInputs[3].innerText,
        //"Field04": jqInputs[4].innerText,
        //"Field05": jqInputs[5].innerText,
        //"Field06": jqInputs[6].innerText
    });

    $.ajax({
        type: 'POST',
        data: { SerializedData: sdt },
        url: '/Planning/SaveTable1Record',
        success: function (response) {

            var jqTds = $('>td', nRow1);
            jqTds[0].innerHTML = parseInt(response);

            oTable1.fnDraw();

            nEditing1 = null;

            AttachEdit(oTable1, true);
            AttachDelete(oTable1);

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log("Status: " + textStatus + "; Error: " + errorThrown);

            oTable1.fnDraw();

            nEditing1 = null;

            AttachEdit(oTable1, true);
            AttachDelete(oTable1);
        }
    });
}

//GRID2 SECTION

var oTable2 = null;
var nEditing2 = null;

function AttachEdit2(oTable2, excludeRestore) {

    $('#datatable2 a.edit').on('click', function (e) {

        e.preventDefault();

        /* Get the row as a parent of the link that was clicked on */
        var nRow2 = $(this).parents('tr')[0];

        if (nEditing2 !== null && nEditing2 !== nRow2) {

            /* Currently editing - but not this row - restore the old before continuing to edit mode */
            if (!excludeRestore) {
                restoreRow2(oTable2, nEditing2);

                editRow2(oTable2, nRow2);
                nEditing2 = nRow2;
            }
        }
        else if (nEditing2 === nRow2 && this.innerHTML === "Save") {

            /* Editing this row and want to save it */
            saveRow2(oTable2, nEditing2);
            nEditing2 = null;
        }
        else {

            /* No edit in progress - let's start one */
            editRow2(oTable2, nRow2);
            nEditing2 = nRow2;
        }
    });
}

function RemoveRow2FromServer(rid) {
    $.ajax({
        type: 'POST',
        data: { RowID: rid },
        url: '/Planning/RemoveTable2Record',
        success: function (response) {
            //DELETE SUCCESS!
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.info("Status: " + textStatus + "; Error: " + errorThrown);
            //DELETE ISSUE!
        }
    });
}

function AttachDelete2(oTable2) {

    $('#datatable2 a.delete').on('click', function (e) {

        e.preventDefault();

        var nRow2 = $(this).parents('tr')[0];
        //NEW
        var aData = oTable2.fnGetData(nRow2);

        switch (this.innerHTML) {
            case "Delete":
                oTable2.fnDeleteRow(nRow2);

                //NEW
                RemoveRow2FromServer(aData[0]);

                break;
            case "Cancel":
                cancelRow2(oTable2, nRow2);
                nEditing2 = null;
                break;
        }
    });
}

function restoreRow2(oTable2, nRow2) {

    var aData = oTable2.fnGetData(nRow2);

    if (aData === null)
        return;

    var jqTds = $('>td', nRow2);

    for (var i = 0, iLen = jqTds.length - 1; i < iLen; i++) {
        oTable2.fnUpdate(aData[i], nRow2, i, false);
    }

    oTable2.fnDraw();
}

function cancelRow2(oTable2, nRow2) {

    var aData = oTable2.fnGetData(nRow2);
    var jqTds = $('>td', nRow2);

    jqTds[0].innerHTML = aData[0];
    jqTds[1].innerHTML = aData[1];
    jqTds[2].innerHTML = aData[2];
    jqTds[3].innerHTML = aData[3];
    jqTds[4].innerHTML = aData[4];
    //jqTds[5].innerHTML = aData[5];

    jqTds[6].innerHTML = jqTds[6].innerHTML.replace('>Save<', '>Edit<');
    jqTds[7].innerHTML = jqTds[7].innerHTML.replace('>Cancel<', '>Delete<');

    nEdit2 = null;

    AttachEdit2(oTable2, true);
    AttachDelete2(oTable2);
}

function editRow2(oTable2, nRow2) {

    var aData = oTable2.fnGetData(nRow2);
    var jqTds = $('>td', nRow2);

    if (jqTds.length === 0)
        return;

    //DO NOT ALLOW RECORD ID EDIT
    //jqTds[0].innerHTML = '<input type="text" size="15px" value="' + aData[0] + '">';
    jqTds[1].innerHTML = '<input type="text" size="10px" value="' + aData[1] + '">';
    jqTds[2].innerHTML = '<input type="text" size="10px" value="' + aData[2] + '">';
    jqTds[3].innerHTML = '<input type="text" size="10px" value="' + aData[3] + '">';
    jqTds[4].innerHTML = '<input type="text" size="10px" value="' + aData[4] + '">';
    //jqTds[5].innerHTML = '<input type="text" size="36px" value="' + aData[5] + '">';

    jqTds[6].innerHTML = jqTds[6].innerHTML.replace('>Edit<', '>Save<');

    //Only offer cancel if they are truly editing an existing record. 
    // Sometimes this method is called with new records, in which case,
    // delete is more appropriate than cancel...we don't want to leave
    // intact the values as read-only
    if (aData[0].length > 0)
        jqTds[7].innerHTML = jqTds[7].innerHTML.replace('>Delete<', '>Cancel<');

    AttachEdit2(oTable2, true);
    AttachDelete2(oTable2);
}

function saveRow2(oTable2, nRow2) {

    var jqInputs = $('input', nRow2);

    oTable2.fnUpdate(jqInputs[0].value, nRow2, 1, false);
    oTable2.fnUpdate(jqInputs[1].value, nRow2, 2, false);
    oTable2.fnUpdate(jqInputs[2].value, nRow2, 3, false);
    oTable2.fnUpdate(jqInputs[3].value, nRow2, 4, false);
    //oTable2.fnUpdate(jqInputs[4].value, nRow2, 5, false);
    //oTable2.fnUpdate(jqInputs[5].value, nRow2, 6, false);

    oTable2.fnUpdate('<a class="edit btn btn-sm btn-outline-primary" href="#">Edit</a>', nRow2, 6, false);
    oTable2.fnUpdate('<a class="delete btn btn-sm btn-outline-secondary" href="#">Delete</a>', nRow2, 7, false);

    jqInputs = $('>td', nRow2);

    var sdt = JSON.stringify({
        "Field00": jqInputs[0].innerText,
        "Field01": jqInputs[1].innerText,
        "Field02": jqInputs[2].innerText,
        "Field03": jqInputs[3].innerText //,
        //"Field04": jqInputs[4].innerText,
        //"Field05": jqInputs[5].innerText,
        //"Field06": jqInputs[6].innerText
    });

    $.ajax({
        type: 'POST',
        data: { SerializedData: sdt },
        url: '/Planning/SaveTable2Record',
        success: function (response) {

            var jqTds = $('>td', nRow2);
            jqTds[0].innerHTML = parseInt(response);

            oTable2.fnDraw();

            nEditing2 = null;

            AttachEdit2(oTable2, true);
            AttachDelete2(oTable2);

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log("Status: " + textStatus + "; Error: " + errorThrown);

            oTable2.fnDraw();

            nEditing2 = null;

            AttachEdit2(oTable2, true);
            AttachDelete2(oTable2);
        }
    });
}

//GRID4 SECTION

var oTable4 = null;
var nEditing4 = null;

function AttachEdit4(oTable4, excludeRestore) {

    var editButtons = $('#datatable4 a.edit');

    if (editButtons.length === 0)
        return;

    $('#datatable4 a.edit').on('click', function (e) {

        e.preventDefault();

        /* Get the row as a parent of the link that was clicked on */
        var nRow4 = $(this).parents('tr')[0];

        if (nEditing4 !== null && nEditing4 !== nRow4) {

            /* Currently editing - but not this row - restore the old before continuing to edit mode */
            if (!excludeRestore) {
                restoreRow4(oTable4, nEditing4);

                editRow4(oTable4, nRow4);
                nEditing4 = nRow4;
            }

        }
        else if (nEditing4 === nRow4 && this.innerHTML === "Save") {

            /* Editing this row and want to save it */
            saveRow4(oTable4, nEditing4);
            nEditing4 = null;
        }
        else {

            /* No edit in progress - let's start one */
            editRow4(oTable4, nRow4);
            nEditing4 = nRow4;
        }
    });
}

function AttachDelete4(oTable4) {

    var deleteButtons = $('#datatable4 a.delete');

    if (deleteButtons.length === 0)
        return;

    $('#datatable4 a.delete').on('click', function (e) {

        e.preventDefault();

        var nRow4 = $(this).parents('tr')[0];

        switch (this.innerHTML) {
            case "Delete":
                oTable4.fnDeleteRow(nRow4);
                break;
            case "Cancel":
                cancelRow4(oTable4, nRow4);
                nEditing4 = null;
                break;
        }
    });
}

function restoreRow4(oTable4, nRow4) {

    if (nRow4 === null)
        return;

    var aData = oTable4.fnGetData(nRow4);

    //if (aData == null)
    //    return;

    var jqTds = $('>td', nRow4);

    for (var i = 0, iLen = jqTds.length; i < iLen; i++) {
        oTable4.fnUpdate(aData[i], nRow4, i, false);
    }

    oTable4.fnDraw();
}

function cancelRow4(oTable4, nRow4) {

    if (nRow4 === null)
        return;

    var aData = oTable4.fnGetData(nRow4);
    var jqTds = $('>td', nRow4);

    jqTds[0].innerHTML = aData[0];
    jqTds[1].innerHTML = aData[1];
    jqTds[2].innerHTML = aData[2];
    jqTds[3].innerHTML = aData[3];
    jqTds[4].innerHTML = aData[4];
    jqTds[5].innerHTML = aData[5];
    jqTds[6].innerHTML = aData[6];
    jqTds[7].innerHTML = aData[7];
    jqTds[8].innerHTML = aData[8];

    jqTds[9].innerHTML = aData[9];
    jqTds[10].innerHTML = aData[10];
    jqTds[11].innerHTML = aData[11];

    jqTds[12].innerHTML = jqTds[12].innerHTML.replace('>Save<', '>Edit<');
    jqTds[13].innerHTML = jqTds[13].innerHTML.replace('>Cancel<', '>Delete<');

    nEditing4 = null;

    AttachEdit4(oTable4, true);
    AttachDelete4(oTable4);
}

function editRow4(oTable4, nRow4) {

    if (nRow4 === null)
        return;

    var aData = oTable4.fnGetData(nRow4);
    var jqTds = $('>td', nRow4);

    //if (jqTds.length == 0)
    //    return;

    //DO NOT ALLOW RECORD ID EDIT
    //jqTds[0].innerHTML = '<input type="text" size="2" value="' + aData[0] + '">';

    jqTds[1].innerHTML = '<input type="text" size="12" value="' + aData[1] + '">';
    jqTds[2].innerHTML = '<input type="text" size="7" value="' + aData[2] + '">';
    jqTds[3].innerHTML = '<input type="text" size="7" value="' + aData[3] + '">';
    jqTds[4].innerHTML = '<input type="text" size="1" value="' + aData[4] + '">';


    //USER CANNOT EDIT BAR CHART
    //jqTds[5].innerHTML = aData[5];    

    jqTds[6].innerHTML = '<input type="text" size="1" value="' + aData[6] + '">';

    //Edit date okay
    jqTds[7].innerHTML = '<input type="text" size="7" value="' + aData[7] + '">';

    //DO NOT ALLOW TOTAL WEIGHT EDIT
    //jqTds[8].innerHTML = '<input type="text" size="3" value="' + aData[8] + '">';

    jqTds[9].innerHTML = '<input type="text" size="1" value="' + aData[9] + '">';
    jqTds[10].innerHTML = '<input type="text" size="2" value="' + aData[10] + '">';
    jqTds[11].innerHTML = '<input type="text" size="2" value="' + aData[11] + '">';

    jqTds[12].innerHTML = jqTds[12].innerHTML.replace('>Edit<', '>Save<');

    //Only offer cancel if they are truly editing an existing record. 
    // Sometimes this method is called with new records, in which case,
    // delete is more appropriate than cancel...we don't want to leave
    // intact the values as read-only
    if (aData[0].length > 0)
        jqTds[13].innerHTML = jqTds[13].innerHTML.replace('>Delete<', '>Cancel<');

    AttachEdit4(oTable4, true);
    AttachDelete4(oTable4);
}

function saveRow4(oTable4, nRow4) {

    var jqInputs = $('input', nRow4);

    //oTable4.fnUpdate(jqInputs[0].value, nRow4, 0, false);
    oTable4.fnUpdate(jqInputs[0].value, nRow4, 1, false);
    oTable4.fnUpdate(jqInputs[1].value, nRow4, 2, false);
    oTable4.fnUpdate(jqInputs[2].value, nRow4, 3, false);
    oTable4.fnUpdate(jqInputs[3].value, nRow4, 4, false);

    var multWeight = parseFloat(jqInputs[9].value);
    var remWeight = parseFloat(jqInputs[10].value);

    var totalWeight = multWeight + remWeight;

    var multWidth = multWeight / 40.0;
    var remWidth = remWeight / 40.0;

    var updatedBarChartMarkup = '<div class="demo-vertical-spacing-sm"><div class="btn-group btn-group-toggle" data-toggle="buttons"><label class="btn btn-sm btn-primary" style="width: '
        + multWidth + 'px; height: 20px;"><input type="checkbox"></label><label class="btn btn-sm btn-outline-secondary" style="width: '
        + remWidth + 'px; height: 20px;"><input type="checkbox"></label></div></div>';

    oTable4.fnUpdate(updatedBarChartMarkup, nRow4, 5, false);

    oTable4.fnUpdate(jqInputs[6].value, nRow4, 6, false);
    oTable4.fnUpdate(jqInputs[7].value, nRow4, 7, false);
    oTable4.fnUpdate(totalWeight.toFixed(1), nRow4, 8, false);
    oTable4.fnUpdate(jqInputs[8].value, nRow4, 9, false);
    oTable4.fnUpdate(multWeight.toFixed(1), nRow4, 10, false);
    oTable4.fnUpdate(remWeight.toFixed(1), nRow4, 11, false);

    oTable4.fnUpdate('<a class="edit btn btn-sm btn-outline-primary" href="#">Edit</a>', nRow4, 12, false);
    oTable4.fnUpdate('<a class="delete btn btn-sm btn-outline-secondary" href="#">Delete</a>', nRow4, 13, false);

    jqInputs = $('>td', nRow4);

    var sdt = JSON.stringify({
        "Field00": jqInputs[0].innerText,
        "Field01": jqInputs[1].innerText,

        "Field02": jqInputs[2].innerText,

        "Field03": jqInputs[3].innerText,
        "Field04": jqInputs[4].innerText,

        //Field 5 is chart...do not collect
        "Field06": jqInputs[6].innerText,
        "Field07": jqInputs[7].innerText,
        //Field 8 is calculated...do not collect
        "Field09": jqInputs[9].innerText,
        "Field10": jqInputs[10].innerText,
        "Field11": jqInputs[11].innerText
    });

    $.ajax({
        type: 'POST',
        data: { SerializedData: sdt },
        url: '/Planning/SaveTable4Record',
        success: function (response) {

            var jqTds = $('>td', nRow4);
            jqTds[0].innerHTML = parseInt(response);

            oTable4.fnDraw();

            nEditing4 = null;

            AttachEdit4(oTable4, true);
            AttachDelete4(oTable4);

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.info("Status: " + textStatus + "; Error: " + errorThrown);

            oTable4.fnDraw();

            nEditing4 = null;

            AttachEdit4(oTable4, true);
            AttachDelete4(oTable4);
        }
    });
}

function WireUpTable4Buttons() {

    oTable4 = $('#datatable4').dataTable({
        processing: true,
        info: false,
        paging: false,
        filter: false
    });

    AttachEdit4(oTable4, false);
    AttachDelete4(oTable4);

}

$(document).ready(function () {

    //GRID1 SECTION
    oTable1 = $('#datatable1').dataTable({
        processing: true,
        info: false,
        paging: false,
        filter: false,
        ordering: false,
        orderable: false
    });

    $('#new1').click(function (e) {

        e.preventDefault();

        var aiNew = oTable1.fnAddData([
            '',
            '',
            '',
            '',
            '',
            '',
            '<a class="edit btn btn-sm btn-outline-primary" href="#">Edit</a>',
            '<a class="delete btn btn-sm btn-outline-secondary" href="#">Delete</a>']);

        var nRow1 = oTable1.fnGetNodes(aiNew[0]);
        editRow(oTable1, nRow1);
        nEditing1 = nRow1;

    });

    AttachEdit(oTable1, false);
    AttachDelete(oTable1);

    //GRID2 SECTION
    oTable2 = $('#datatable2').dataTable({
        processing: true,
        info: false,
        paging: false,
        filter: false,
        ordering: false,
        orderable: false
    });

    $('#new2').click(function (e) {

        e.preventDefault();

        var aiNew = oTable2.fnAddData([
            '',
            '',
            '',
            '',
            '',
            '<input data-val="true" id="mlt_Test_New" type="checkbox">',
            '<a class="edit btn btn-sm btn-outline-primary" href="#">Edit</a>',
            '<a class="delete btn btn-sm btn-outline-secondary" href="#">Delete</a>']);
        //'<input data-val="true" id="mlt_Test_New" type="checkbox">',
        var nRow2 = oTable2.fnGetNodes(aiNew[0]);
        editRow2(oTable2, nRow2);
        nEditing2 = nRow2;

    });

    AttachEdit2(oTable2, false);
    AttachDelete2(oTable2);

    WireUpTable4Buttons();

});


var onSearchSubmitSuccess = function (context) {

    $("#divSearchResult").html(context);

    WireUpTable4Buttons();
};

var onSearchSubmitBegin = function () {

};

var onSearchSubmitComplete = function () {

};

var onSearchSubmitFailed = function (context) {

};