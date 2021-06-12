//FUNCTION TO DISPLAY SELECTED ITEMS IN DROPDOWN LISTS; ALSO UPDATES CORRESPONDING HIDDEN VALUE THAT WOULD OTHERWISE
// NOT COME BACK IN THE MODEL
$(function () {

    $(".dropdown-menu li a").click(function () {

        console.info('Attaching drop down list event handler');

        $(this).parents(".dropdown").find('.btn').html($(this).text() + ' <span class="caret"></span>');
        //$(this).parents(".dropdown").find('.btn').val($(this).data('value'));

        var newId = $(this)[0].id;

        console.info('new id: ' + $(this)[0]);

        switch ($(this).parents(".dropdown").find('.btn')[0].id) {
            case "DiscreteJobSelected":
                window.location = '/Saws/Index/' + newId;
                break;
            case "ddlShape":

                $("#HiddenBarShapeSelected1").val(newId);
                $("#HiddenBarShapeSelected2").val(newId);

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
                break;
            case "ddlMaterial":
                $("#HiddenMaterialName").val(newId);
                break;
            case "ddlLot":
                $("#HiddenLotNumberSelected1").val(newId);
                $("#HiddenLotNumberSelected2").val(newId);
                break;
            case "ddlDirection":
                $("#HiddenBilletDirectionSelected").val(newId);
                break;
            case "ddlTargetWeight":
                $("#HiddenTargetWeightSelected").val(newId);
                break;
            case "ddlSaw":
                $("#HiddenSawMachineSelected1").val(newId);
                $("#HiddenSawMachineSelected2").val(newId);
                break;
            case "ddlBlade":
                $("#HiddenBladeSelected1").val(newId);
                $("#HiddenBladeSelected2").val(newId);
                break;
            case "ddlTpiRange":
                $("#HiddenTpiRangeSelected1").val(newId);
                $("#HiddenTpiRangeSelected2").val(newId);
                break;
        }
    }); 
}); 

/*
//TEMP REM UNTIL EVAN GETS BAR DISTRIBUTION WORKING
// WITH SIDE NAV TOGGLED TO MIN (FOR APP ENTRY).  THIS GIVES THE LARGEST POSSIBLE CHART
function makeBars(barData)
{
    //Reset chart; sometimes we are replacing an existing chart
    $("#barDiv").html("");

    //NOTE: THIS IS ALSO IN site_appentry.js...LEAVE IT THERE BECAUSE OTHER SCREENS WILL BEING DOING THIS AND NEEDING TO STORE THE SETTING IN LOCAL STORAGE
    //if (!window.layoutHelpers.isCollapsed())
    //    window.layoutHelpers.toggleCollapsed();

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

*/

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

function addAxesAndLegend(svg, xAxis, yAxis, margin, chartWidth, chartHeight) {

    console.info('Add axes');

    svg.append('clipPath')
        .attr('id', 'axes-clip')
        .append('polygon')
        .attr('points', (-margin.left) + ',' + (-margin.top) + ' ' +
            (chartWidth - 1) + ',' + (-margin.top) + ' ' +
            (chartWidth - 1) + ',' + (chartHeight + margin.bottom) + ' ' +
            (-margin.left) + ',' + (chartHeight + margin.bottom));

    var axes = svg.append('g')
        .attr('clip-path', 'url(#axes-clip)');

    axes.append('g')
        .attr('class', 'x axis')
        .attr('transform', 'translate(0,' + chartHeight + ')')
        .call(xAxis);

    axes.append('g')
        .attr('class', 'y axis')
        .call(yAxis)
        .append('text')
        .attr('transform', 'rotate(-90)')
        .attr('y', 6)
        .attr('dy', '.71em')
        .style('text-anchor', 'end')
        .text('Variance (%)');

    //var legend = svg.append('g')
    //    .attr('class', 'legend')
    //    .attr('transform', 'translate(' + (chartWidth - legendWidth) + ', 0)');

    //legend.append('rect')
    //    .attr('class', 'legend-bg')
    //    .attr('width', legendWidth)
    //    .attr('height', legendHeight);

    //legend.append('rect')
    //    .attr('class', 'outer')
    //    .attr('width', 75)
    //    .attr('height', 20)
    //    .attr('x', 10)
    //    .attr('y', 10);

    //legend.append('text')
    //    .attr('x', 115)
    //    .attr('y', 25)
    //    .text('5% - 95%');

    //legend.append('rect')
    //    .attr('class', 'inner')
    //    .attr('width', 75)
    //    .attr('height', 20)
    //    .attr('x', 10)
    //    .attr('y', 40);

    //legend.append('text')
    //    .attr('x', 115)
    //    .attr('y', 55)
    //    .text('25% - 75%');

    //legend.append('path')
    //    .attr('class', 'median-line')
    //    .attr('d', 'M10,80L85,80');

    //legend.append('text')
    //    .attr('x', 115)
    //    .attr('y', 85)
    //    .text('Median');
}

function drawPaths(svg, data, x, y) {

    console.info('Draw paths');

    //var color1 = $("#colorSample1").css("background-color");
    //var color2 = $("#colorSample2").css("background-color");
    var color3 = $("#colorSample3").css("background-color");
    //var color4 = $("#colorSample4").css("background-color");    
    //var color5 = $("#colorSample5").css("background-color");
    var color6 = $("#colorSample6").css("background-color");

    var color3Opacity = "0.8";
    var color6Opacity = "1.0";

    color3 = color3.replace("rgb", "rgba");
    color6 = color6.replace("rgb", "rgba");

    color3 = color3.replace(")", ", " + color6Opacity + ")");
    color6 = color6.replace(")", ", " + color3Opacity + ")");

    var upperOuterArea = d3.area()
        .curve(d3.curveBasis)
        .x(function (d) { return x(d.date) || 1; })
        .y0(function (d) { return y(d.pct95); })
        .y1(function (d) { return y(d.pct75); });

    var upperInnerArea = d3.area()
        .curve(d3.curveBasis)
        .x(function (d) { return x(d.date) || 1; })
        .y0(function (d) { return y(d.pct75); })
        .y1(function (d) { return y(d.pct50); });

    //var medianLine = d3.line()
    //    .curve(d3.curveBasis)
    //    .x(function (d) { return x(d.date); })
    //    .y(function (d) { return y(d.pct50); });

    var lowerInnerArea = d3.area()
        .curve(d3.curveBasis)
        .x(function (d) { return x(d.date) || 1; })
        .y0(function (d) { return y(d.pct50); })
        .y1(function (d) { return y(d.pct25); });

    var lowerOuterArea = d3.area()
        .curve(d3.curveBasis)
        .x(function (d) { return x(d.date) || 1; })
        .y0(function (d) { return y(d.pct25); })
        .y1(function (d) { return y(d.pct05); });

    svg.datum(data);

    svg.append('path')
        .attr('class', 'area upper outer')
        .attr('fill', color6)
        .attr('d', upperOuterArea)
        .attr('clip-path', 'url(#rect-clip)');

    svg.append('path')
        .attr('class', 'area lower outer')
        .attr('fill', color6)
        .attr('d', lowerOuterArea)
        .attr('clip-path', 'url(#rect-clip)');

    svg.append('path')
        .attr('class', 'area upper inner')
        .attr('fill', color3)
        .attr('d', upperInnerArea)
        .attr('clip-path', 'url(#rect-clip)');

    svg.append('path')
        .attr('class', 'area lower inner')
        .attr('fill', color3)
        .attr('d', lowerInnerArea)
        .attr('clip-path', 'url(#rect-clip)');

    //svg.append('path')
    //    .attr('class', 'median-line')
    //    .attr('d', medianLine)
    //    .attr('clip-path', 'url(#rect-clip)');
}

function GetPosEnd(altitude) {
    var rtv = 170 - altitude * 90;
    return rtv;
}

function addMarker(marker, svg, chartHeight, x) {

    var radius = 8,
        xPos = x(marker.date) - radius - 3,
        yPosStart = chartHeight - radius - 3,
        yPosEnd = GetPosEnd(marker.altitude, radius);

    var markerG = svg.append('g')
        .attr('class', 'marker ' + marker.type)
        .attr('transform', 'translate(' + xPos + ', ' + yPosStart + ')')
        .attr('opacity', 0);

    markerG.transition()
        .duration(1000)
        .attr('transform', 'translate(' + xPos + ', ' + yPosEnd + ')')
        .attr('opacity', 1);

    markerG.append('path')
        .attr('d', 'M' + radius + ',' + (chartHeight - yPosStart) + 'L' + radius + ',' + (chartHeight - yPosStart))
        .transition()
        .duration(1000)
        .attr('d', 'M' + radius + ',' + (chartHeight - yPosEnd) + 'L' + radius + ',' + (radius * 2));

    markerG.append('circle')
        .attr('class', 'marker-bg')
        .attr('cx', radius)
        .attr('cy', radius)
        .attr('r', radius);

    //markerG.append('text')
    //    .attr('x', radius)
    //    .attr('y', radius * 0.9)
    //    .text(marker.type);

    //markerG.append('text')
    //    .attr('x', radius)
    //    .attr('y', radius * 1.5)
    //    .text(marker.version);
}

function startTransitions(svg, chartWidth, chartHeight, rectClip, markers, x) {
    rectClip.transition()
        .duration(1000 * markers.length)
        .attr('width', chartWidth);

    markers.forEach(function (marker, i) {
        setTimeout(function () {
            addMarker(marker, svg, chartHeight, x);
        }, 1000 + 500 * i);
    });
}

function makeChart(data, markers) {

    console.info('Make chart');

    var scatterWidth = $('#scatterDiv').parent().width();

    //console.info('ScatterWidth: ' + scatterWidth);

    var svgWidth = scatterWidth,
        svgHeight = 375,
        margin = { top: 10, right: 20, bottom: 10, left: 40 },
        chartWidth = svgWidth - margin.left - margin.right,
        chartHeight = svgHeight - margin.top - margin.bottom;

    var x = d3.scaleTime().range([0, chartWidth])
        .domain(d3.extent(data, function (d) { return d.date; })),
        y = d3.scaleLinear().range([chartHeight, 0])
            .domain([-2.0, 2.0]);

    var xAxis = d3.axisBottom(x)
        .tickSizeInner(-chartHeight).tickSizeOuter(0).tickPadding(10),
        yAxis = d3.axisLeft(y)
            .tickSizeInner(-chartWidth).tickSizeOuter(0).tickPadding(10);

    var svg = d3.select('.scatterVariance').append('svg').attr('width', svgWidth).attr('height', svgHeight).append('g')
        .attr('transform', 'translate(' + margin.left + ',' + margin.top + ')');

    // clipping to start chart hidden and slide it in later
    var rectClip = svg.append('clipPath')
        .attr('id', 'rect-clip')
        .append('rect')
        .attr('width', 0)
        .attr('height', chartHeight);

    //console.info('Adding chart axis');

    addAxesAndLegend(svg, xAxis, yAxis, margin, chartWidth, chartHeight);
    drawPaths(svg, data, x, y);
    startTransitions(svg, chartWidth, chartHeight, rectClip, markers, x);

    //console.info('Finished Make-Chart');
}

function sleep(milliseconds) {
    var start = new Date().getTime();
    for (var i = 0; i < 1e7; i++) {
        if ((new Date().getTime() - start) > milliseconds) {
            break;
        }
    }
}

//TODO: IS THIS ALSO NEEDING TO PERFORM THE FULL CLICK EVENT TO GET THE LEFT PANEL DDL IN SYNC?????
function SelectTableTab() {

    console.info('Select table tab');

    $("#bottom-center-table").addClass('active show');
    $("#bottom-center-chart").removeClass('active show');

    $("#bottom-center-table-nav").addClass('active show');
    $("#bottom-center-chart-nav").removeClass('active show'); 
}

function RefreshChartData(locationCode, shopOrderNumber, selectTabFollowing) {    

    console.info('Refresh chart data');

    $.get("/Saws/GetScatterData",
        { loc: locationCode, son: shopOrderNumber },
        function (dataResponse) {

            console.info('Get Scatter Data');

            $.get("/Saws/GetScatterMarkers",
                { loc: locationCode, son: shopOrderNumber },
                function (markerResponse) {                    

                    console.info('Get Scatter Markers');

                    var parseDate = d3.timeParse('%Y-%m-%d');
                    var rawData = dataResponse;

                    var data = rawData.map(function (d) {
                        return {
                            date: parseDate(d.date),
                            pct05: d.pct05 / 1000,
                            pct25: d.pct25 / 1000,
                            pct50: d.pct50 / 1000,
                            pct75: d.pct75 / 1000,
                            pct95: d.pct95 / 1000
                        };
                    });

                    var markerData = markerResponse;

                    var markers = markerData.map(function (marker) {
                        return {
                            date: parseDate(marker.date),
                            type: marker.type,
                            altitude: marker.altitude
                        };
                    });

                    makeChart(data, markers);

                    if (selectTabFollowing)
                        SelectTableTab();
                }
            );
        }
    );
}

//GRID1 SECTION

var oTable1 = null;
var nEditing1 = null;

function AttachEdit(oTable1, excludeRestore)
{
    console.info('Attach edit to table 1');

    $('#datatable1 a.edit').on('click', function (e) {

        e.preventDefault();

        /* Get the row as a parent of the link that was clicked on */
        var nRow1 = $(this).parents('tr')[0];

        if (nEditing1 !== null && nEditing1 !== nRow1) {

            /* Currently editing - but not this row - restore the old before continuing to edit mode */
            if (!excludeRestore) {
                //restoreRow(oTable1, nEditing1);

                editRow(oTable1, nRow1);
                nEditing1 = nRow1;
            }
        }
        else {
            editRow(oTable1, nRow1);
            nEditing1 = nRow1;
        }
    });
}

function AttachDelete(oTable1)
{
    console.info('Attach delete to table 1');

    $('#datatable1 a.delete').on('click', function (e) {

        e.preventDefault();

        var nRow1 = $(this).parents('tr')[0];
        var pieceID = nRow1.id;        

        if (this.innerHTML === "Delete")
        {
            $.ajax({
                url: "/Saws/SawPanelDeleteMultPartial",
                cache: false,
                data: { pid: pieceID },
                dataType: "html",
                contentType: "json",
                success: function (response) {
                    $("#divPanel2Center").html(response);
                },
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    console.info("Status: " + textStatus + "Error: " + errorThrown);
                }
            });
        }
    });
}

//function restoreRow(oTable1, nRow1) {

    //var aData = oTable1.fnGetData(nRow1);

    //if (aData == null)
    //    return;

    //var jqTds = $('>td', nRow1);

    //for (var i = 0, iLen = jqTds.length; i < iLen; i++) {
    //    oTable1.fnUpdate(aData[i], nRow1, i, false);
    //}

    //oTable1.fnDraw();
//}

//function cancelRow(oTable1, nRow1) {

    //var aData = oTable1.fnGetData(nRow1);
    //var jqTds = $('>td', nRow1);

    //jqTds[0].innerHTML = aData[0];
    //jqTds[1].innerHTML = aData[1];
    //jqTds[2].innerHTML = aData[2];
    //jqTds[3].innerHTML = aData[3];
    //jqTds[4].innerHTML = aData[4];
    //jqTds[5].innerHTML = aData[5];

    //jqTds[6].innerHTML = jqTds[6].innerHTML.replace('>Save<', '>Edit<');
    //jqTds[7].innerHTML = jqTds[7].innerHTML.replace('>Cancel<', '>Delete<');

    //nEdit1 = null;

    //AttachEdit(oTable1, true);
    //AttachDelete(oTable1);
//}

function editRow(oTable1, nRow1)
{
    console.info('Edit row');

    var pieceId = nRow1.id;

    $.ajax({
        url: "/Saws/SawPanelEditMultPartial",
        cache: false,
        data: { pid: pieceId },
        dataType: "html",
        contentType: "json",
        success: function (response) {
            $("#divPanel2Center").html(response);
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.info("Status: " + textStatus + "Error: " + errorThrown);
        }
    });

    //var aData = oTable1.fnGetData(nRow1);
    //var jqTds = $('>td', nRow1);

    //if (jqTds.length == 0)
    //    return;

    //jqTds[0].innerHTML = '<input type="text" size="5px" value="' + aData[0] + '">';
    //jqTds[1].innerHTML = '<input type="text" size="5px" value="' + aData[1] + '">';
    //jqTds[2].innerHTML = '<input type="text" size="2px" value="' + aData[2] + '">';
    //jqTds[3].innerHTML = '<input type="text" size="4px" value="' + aData[3] + '">';
    //jqTds[4].innerHTML = '<input type="text" size="4px" value="' + aData[4] + '">';
    //jqTds[5].innerHTML = '<input type="text" size="4px" value="' + aData[5] + '">';

    //jqTds[6].innerHTML = jqTds[6].innerHTML.replace('>Edit<', '>Save<');

    ////Only offer cancel if they are truly editing an existing record. 
    //// Sometimes this method is called with new records, in which case,
    //// delete is more appropriate than cancel...we don't want to leave
    //// intact the values as read-only
    //if (aData[0].length > 0)
    //    jqTds[7].innerHTML = jqTds[7].innerHTML.replace('>Delete<', '>Cancel<');

    //AttachEdit(oTable1, true);
    //AttachDelete(oTable1);
}

//function saveRow(oTable1, nRow1) {

    //$.ajax({
    //    url: "/Saws/SawPanelEditMultPartial",
    //    cache: false,
    //    data: $("#form").serialize(),
    //    type: 'POST',
    //    //dataType: "html",
    //    contentType: 'application/json; charset=utf-8',
    //    success: function (response) {
    //        $("#divPanelCenter").html(response);
    //    },
    //    error: function (XMLHttpRequest, textStatus, errorThrown) {
    //        console.info("Status: " + textStatus + "Error: " + errorThrown);
    //    }
    //});

    //var jqInputs = $('input', nRow1);

    //oTable1.fnUpdate(jqInputs[0].value, nRow1, 0, false);
    //oTable1.fnUpdate(jqInputs[1].value, nRow1, 1, false);
    //oTable1.fnUpdate(jqInputs[2].value, nRow1, 2, false);
    //oTable1.fnUpdate(jqInputs[3].value, nRow1, 3, false);
    //oTable1.fnUpdate(jqInputs[4].value, nRow1, 4, false);
    //oTable1.fnUpdate(jqInputs[5].value, nRow1, 5, false);

    //oTable1.fnUpdate('<a class="edit btn btn-sm btn-outline-primary" href="#">Edit</a>', nRow1, 6, false);
    //oTable1.fnUpdate('<a class="delete btn btn-sm btn-outline-secondary" href="#">Delete</a>', nRow1, 7, false);

    //oTable1.fnDraw();

    //nEditing1 = null;

    //AttachEdit(oTable1, true);
    //AttachDelete(oTable1);
//}

//THIS REFRESHES THE ENTIRE PAGE IF THE USER HAND ENTERS A NEW JOB NUMBER
// AND PRESSES ENTER, TO SEE A NEW JOB, IE. NOT USE DDL; ALSO IT REFRESHES
// THE ENTIRE PAGE IF USER CLICKS THE SAVE BUTTON, WHICH IS FINE BECAUSE
// THAT GIVES A VISUAL CLUE THAT THE SAVE BUTTON WORKS.
var onEditJobLeftSuccess = function (context)
{
    console.info('On edit job left success');

    //var locationCode = $("#HiddenLocation").val();
    var shopOrderNumber = $("#HiddenShopOrderNumber").val();

    //window.location = '/Saws/Index/' + shopOrderNumber;
    //$("#DiscreteJobSelected").click();

    $(location).attr('href', '/Saws/Index/' + shopOrderNumber);

};

var onEditJobCenter1Complete = function (context) {

    console.info('On edit job center complete');
    
    var locationCode = $("#HiddenLocation").val();
    var shopOrderNumber = $("#HiddenShopOrderNumber").val();

    //When upper center div updates, potentially we have a new dimension
    //so we need to refresh the right panel
    $.get("/Saws/SawPanelRightPartial",
        { loc: locationCode, son: shopOrderNumber },
        function (response) {
            $("#divPanelRight").html(response);
        }
    );

    //RefreshChartData(locationCode, shopOrderNumber, false);

    ////GRID1 SECTION
    //oTable1 = $('#datatable1').dataTable({
    //    //dom: 'Bfrtip',
    //    //buttons: ['copy', { extend: 'excel', messageTop: 'Sample Header' }, { extend: 'pdf', messageTop: 'Another Sample' }],
    //    processing: true,
    //    info: false,
    //    paging: false,
    //    filter: false,
    //    ordering: false,
    //    orderable: false
    //});

    //AttachEdit(oTable1, false);
    //AttachDelete(oTable1);

};

var onEditJobCenter2Complete = function (context) {

    console.info('On edit Job Center 2 Complete');

    //var locationCode = $("#HiddenLocation").val();
    //var shopOrderNumber = $("#HiddenShopOrderNumber").val();

    //$.get("/Saws/SawPanelRightPartial",
    //    { loc: locationCode, son: shopOrderNumber },
    //    function (response) {
    //        $("#divPanelRight").html(response);
    //    }
    //);

    //RestoreCenter();

};

var onEditJobBegin = function () {

};

var onEditJobComplete = function () {

};

var onEditJobFailed = function (context) {

};

function ConfirmMultDelete() {

    console.info('Delete clicked');

    var pieceId = parseInt($("#HiddenPieceID").val());

    $.ajax({
        url: "/Saws/SawPanelConfirmedDeleteMultPartial",
        type: "GET",
        data: { pid: pieceId },
        dataType: "html",
        success: function (response) {

            $("#divPanel2Center").html(response);

            RestoreCenter();
        },
        error: function (errorThrown) {

            console.info(errorThrown);
        }
    });
}

function SaveMultEdit() {

    console.info('Save edit clicked');

    $.ajax({
        url: "/Saws/SawPanelPostEditCenterPartial",
        method: "GET",
        data: $("form#PieceDetail").serialize(),
        dataType: "html",
        success: function (response) {

            $("#divPanel2Center").html(response);

            RestoreCenter();
        },
        error: function (errorThrown) {

            console.info(errorThrown);
        }
    });
}

function CancelMultEdit() {

    console.info('Cancel clicked');

    var locationCode = $("#HiddenLocation").val();
    var shopOrderNumber = $("#HiddenShopOrderNumber").val();

    $.ajax({
        url: "/Saws/SawPanelCenter2Partial",
        type: "GET",
        data: { loc: locationCode, son: shopOrderNumber },
        dataType: "html",
        success: function (response) {

            console.info('Successful cancel request!');

            $("#divPanel2Center").html(response);

            RestoreCenter();

            console.info('Successful cancel complete!');
        },
        error: function (errorThrown) {

            console.info(errorThrown);
        }
    });
}

/*
function RefreshBarDistribution(locationCode, shopOrderNumber) {

    console.info('Refresh bar data');

    $.ajax({
        url: "/Saws/GetBarDistribution",
        cache: false,
        data: { loc: locationCode, son: shopOrderNumber },
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
*/

function RestoreCenter() {

    var locationCode = $("#HiddenLocation").val();
    var shopOrderNumber = $("#HiddenShopOrderNumber").val();

    //TODO REINSTATE AFTER EVAN'S VERSION IS WORKING
    //RefreshBarDistribution(locationCode, shopOrderNumber);
    RefreshChartData(locationCode, shopOrderNumber, false);

    //GRID1 SECTION
    oTable1 = $('#datatable1').dataTable({
        //dom: 'Bfrtip',
        //buttons: ['copy', { extend: 'excel', messageTop: 'Sample Header' }, { extend: 'pdf', messageTop: 'Another Sample' }],
        processing: true,
        info: false,
        paging: false,
        filter: false,
        ordering: false,
        orderable: false
    });

    AttachEdit(oTable1, false);
    AttachDelete(oTable1);

}

$(document).ready(function ()
{
    console.info('Main doc ready');

    RestoreCenter();

    $('#DiscreteJobSelected').bind('keyup', function (e)
    {
        var shopOrderNumber = $("#DiscreteJobSelected").val();
        $("#HiddenShopOrderNumber").val(shopOrderNumber);   
    });
});