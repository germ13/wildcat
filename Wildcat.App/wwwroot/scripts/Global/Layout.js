function setLocationCookie(buttonElement) {
    var plant = buttonElement.innerText.trim();
    Cookies.set('SelectedLocation', plant);
    window.location = '/Home/Index';
}

function setNavigation() {
    var id = '';

    var urlPath = window.location.pathname;
    urlPath = urlPath.trim().replace(/\/$/, '').replace(/(\/Index)$/, "").replace(/^\//,''); 
    urlPath = decodeURIComponent(urlPath);
    var urlPathArray = urlPath.split('/');

    var href = "";
    while (urlPathArray.length > 0) {
        $(".sidenav-link").each(function () {
            href = $(this).attr('href').trim();
            href = href.replace(/\/$/, '');
            href = href.replace(/(\/Index)$/,'');
            href = href.replace(/^\//, '');

            if (href === urlPathArray.join('/')) {
                id = $(this).parent().attr('id');
                urlPathArray = [];
                return false;
            }
        });
        urlPathArray.pop();
    }

    var selected = document.getElementById(id);
    $(selected).parents('li').addClass('open');
    $(selected).css('border-top', '1px solid #838790');
    $(selected).css('border-bottom', '1px solid #838790');
    $(selected).css('background-color', '1px solid #1b1e22');

    //var path = window.location.pathname;
    //path = path.replace(/\/$/, "");
    //path = decodeURIComponent(path);

    //$(".sidenav-link").each(function () {
    //    var href = $(this).attr('href');
    //    if (path.substring(0, href.length) === href) {
    //        $(this).parents('li').addClass('open');
    //    }
    //});
}

$(document).ready(function () {
    var ps = $("#PlantSelect").button()[0].innerText.trim();
    Cookies.set('SelectedLocation', ps);
    setNavigation();
});
