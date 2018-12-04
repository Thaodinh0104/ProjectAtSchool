﻿//$(document).ready(function () {

//    $(".files").click(function (loadFile) {
//        var files = event.target.files;
//        for (var i = 0; i < files.length; i++) {
//            $("dynamicImage").append("<img scr='" + URL.createObjectURL(event.target.files[i]) + "' class='dynamicimg' /> <br>");
//        }
//    });
//});

//function loadFile(input) {
    // $(".files").click(function (loadFile) {
//        var files = event.target.files;
//        for (var i = 0; i < files.length; i++) {
//            $("dynamicImage").append("<img scr='" + URL.createObjectURL(event.target.files[i]) + "' class='dynamicimg' /> <br>");
//        }
//    });
    //
//}

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('.image-upload').attr('src', e.target.result).width(150).height(200);
        }

            ;

        reader.readAsDataURL(input.files[0]);
    }
}

$("#files").change(function () {
    if (typeof (FileReader) != "undefined") {
        var dvPreview = $("#dvPreview");
        dvPreview.html("");
        var regex = /^([a-zA-Z0-9\s_\\.\-:])+(.jpg|.jpeg|.gif|.png|.bmp)$/;
        $($(this)[0].files).each(function () {
            var file = $(this);
            if (regex.test(file[0].name.toLowerCase())) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    var img = $("<img />");
                    img.attr("style", "height:100px;width: 100px");
                    img.attr("src", e.target.result);
                    dvPreview.append(img);
                }
                reader.readAsDataURL(file[0]);
            } else {
                alert(file[0].name + " is not a valid image file.");
                dvPreview.html("");
                return false;
            }
        });
    } else {
        alert("This browser does not support HTML5 FileReader.");
    }
});
