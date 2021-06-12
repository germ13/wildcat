function changeMenuTeamStatus(e) {
    var sub_id = e.id.split("|")[0];
    var worker_id = e.id.split("|")[1];

    $.ajax({
        url: 'ChangeTeamStatus',
        type: "GET",
        cache: false,
        data: {
            subscriptionId: sub_id,
            workerId: worker_id,
            check: e.checked
            //change_requestby: '@(Context.Request.HttpContext.User.Identity.Name.ToString().Replace("\\","\\\\"))'
        },
        success: function (result) {
            //toastr['success']('Plant menu : ' + worker_id + ' modified', 'Success: modified!', {
            //    positionClass: 'toast-top-right',
            //    closeButton: true,
            //    progressBar: false,
            //    preventDuplicates: true,
            //    newestOnTop: true,
            //    rtl: $('body').attr('dir') === 'rtl' || $('html').attr('dir') === 'rtl'
            //});
            if (result.check) {
                toastr['success'](worker_id + ' added to ' + sub_id + ' menu item.', 'Success: modified!', {
                    positionClass: 'toast-top-right',
                    closeButton: true,
                    progressBar: false,
                    preventDuplicates: true,
                    newestOnTop: true,
                    rtl: $('body').attr('dir') === 'rtl' || $('html').attr('dir') === 'rtl'
                });

            }
            else {
                toastr['success'](worker_id + ' removed from ' + sub_id + ' menu item.', 'Success: modified!', {
                    positionClass: 'toast-top-right',
                    closeButton: true,
                    progressBar: false,
                    preventDuplicates: true,
                    newestOnTop: true,
                    rtl: $('body').attr('dir') === 'rtl' || $('html').attr('dir') === 'rtl'
                });
            }

        },
        error: function (result) {
            toastr['error']('Plant menu : ' + sub_id + ' not modified', 'Error!', {
                positionClass: 'toast-top-right',
                closeButton: true,
                progressBar: false,
                preventDuplicates: true,
                newestOnTop: true,
                rtl: $('body').attr('dir') === 'rtl' || $('html').attr('dir') === 'rtl'
            });
        }
    });
}

var Treeview = function () {
    var demo6 = function () {
        $('#fromTree').jstree({
            "plugins": ["search", "wholerow"],
            'core': {
                'data': {
                    'cache': false,
                    'url': function (node) {
                        var address = '';
                        if (node.id === '#' || node.id === '--') {
                            address = "/Administration/Menu/MenuTree/" + node.id;
                            return address;
                        }
                        else {
                            address = "/Administration/Menu/MenuTree/" + node.data.id;
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

        $("#fromTree").on("click", ".jstree-anchor", function (e) {
            var id = $("#fromTree").jstree(true).get_node($(this)).id;
            if (id !== '#') {
                id = $("#fromTree").jstree(true).get_node($(this)).data.id;
            }
            $.ajax({
                url: "/Administration/Menu/TeamMenuTreeClick/" + id,
                type: "GET",
                cache: false,
                success: function (result) {
                    $('#id_subscriptions').html(result);
                    $.unblockUI();

                },
                error: function (result) {
                    $.unblockUI();

                    $.growl.error({
                        message: result.message
                    });
                }

            });
        });

        $("#fromTree").on("click", ".jstree-icon", function (e) {
            var id = $("#fromTree").jstree(true).get_node($(this)).id;
            if (id !== '#') {
                id = $("#fromTree").jstree(true).get_node($(this)).data.id;
            }
            $.ajax({
                url: "/Administration/Menu/TeamMenuTreeClick/" + id,
                type: "GET",
                cache: false,
                success: function (result) {
                    $('#id_subscriptions').html(result);
                    $.unblockUI();

                },
                error: function (result) {
                    $.unblockUI();

                    $.growl.error({
                        message: result.message
                    });
                }

            });
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
    $('#fromTree').height(windowheight - headerheight - breadcrumbHeight - footerHeight);
    Treeview.init();
});