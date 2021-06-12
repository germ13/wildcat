//document search form submit
$('form').submit(function () {
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

    var serializedForm = $(this).serialize();
    $.ajax({
        url: "/Administration/Menu/AddResponse",
        type: "POST",
        data: serializedForm,
        success: function (result) {
            if (result.success) {
                $.growl.notice({
                    message: result.message
                });
                window.location.href = '/Administration/Menu/Index';
            }
            else {
                $.growl.error({
                    message: result.message
                });
            }

            $.unblockUI();

        },
        error: function (result) {
            $.unblockUI();

            $.growl.error({
                message: result.statusText
            });
        }

    });
    return false;
});

$("#IsRoot").change(function () {
    if ($('#IsRoot').prop('checked')) {
        $("#id").val(0);
        $("#ParentNodeLabel").val("Adding menu to root.");
    }
    else {
        //
        $("#id").val(1);
        var t = $("#m_tree_6").jstree(true).get_node(1);
        $("#ParentNodeLabel").val("Adding menu item to " + t.text + " node.");
    }
});

var Treeview = function () {

    var demo6 = function () {
        $('#m_tree_6').jstree({
            "plugins": ["search", "wholerow"],
            'core': {
                'data': {
                    type: "GET",
                    cache: false,
                    'url': function (node) {
                        var address = '';
                        if (node.id === '#' || node.id === '--') {
                            address = "/Administration/Menu/MenuTree/" + node.id;
                            return address;
                        }
                        else {
                            address = "/Administration/Menu/MenuTree/" + node.id;
                            return address;
                        }
                    },
                    'data': function (node) {
                        if (node.id === '#' || node.id === '--') {
                            return { 'id': '#' };
                        }
                        else {
                            return { 'id': node.id };
                        }
                    }
                }
            }
        });

        $("#m_tree_6").on("click", ".jstree-anchor", function (e) {
            var id = $("#m_tree_6").jstree(true).get_node($(this)).id;
            if (id !== '#') {
                id = $("#m_tree_6").jstree(true).get_node($(this)).id;
                var t = $("#m_tree_6").jstree(true).get_node(id);

                //change value of selected parent
                $("#id").val(id);
                $("#ParentNodeLabel").val("Adding menu item to " + t.text + " node.");
                $('#IsRoot').prop('checked', false);
            }
        });

        $("#m_tree_6").on("click", ".jstree-icon", function (e) {
            var id = $("#m_tree_6").jstree(true).get_node($(this)).id;
            if (id !== '#') {
                id = $("#m_tree_6").jstree(true).get_node($(this)).id;
                var t = $("#m_tree_6").jstree(true).get_node(id);
                //change value of selected parent
                $("#id").val(id);
                $("#ParentNodeLabel").val("Adding menu item to " + t.text + " node.");
                $('#IsRoot').prop('checked', false);
            }
        });
    };

    return {
        //main function to initiate the module
        init: function () {
            demo6();
        }
    };
}();

jQuery(document).ready(function () {
    var windowheight = $(window).innerHeight();
    var headerheight = $("#layout-navbar").innerHeight() * 2;
    var breadcrumbHeight = $(".d-flex").innerHeight();
    var footerHeight = $(".layout-footer").innerHeight() * 2;
    $('#m_tree_6').height(windowheight - headerheight - breadcrumbHeight - footerHeight);
    Treeview.init();
});