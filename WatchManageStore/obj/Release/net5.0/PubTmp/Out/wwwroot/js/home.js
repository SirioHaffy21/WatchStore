
$(document).ready(function () {
    //var btns = document.getElementsByClassName("a-menu");
    //for (var i = 0; i < btns.length; i++) {
    //    btns[i].addEventListener("click", function () {
    //        var current = document.getElementsByClassName("active");
    //        current[0].className = current[0].className.replace("active", "");
    //        this.className += "active";
    //    });
    //}
    $(".dongho").mouseover(function () {
        $(".dropdown-menu").addClass("d-block");
    });

    $(".dongho").mouseout(function () {
        $(".dropdown-menu").removeClass("d-block");
    });
});