$(function () {
    var allspan = $("span.input-group-addon");
    if (allspan.length > 0)
        var index = $(allspan[0]).attr("data-size");
    for (var i = 0, len = allspan.length; i < len; i++) {
        if (index != null) {
            if (i == 0) {
                index = parseInt(index) + 1;
            }
            var label = $(allspan[i]).children("label");
            if (label.size() == 0) {
                var txt = $(allspan[i]).html();
                $(allspan[i]).html("");
                $(allspan[i]).append('<span style="display:block;font-weight:500;margin:0;width:' + index + 'em;">' + txt + '</span>');
            }
            else {
                for (var j = 0, wh = label.length; j < wh; j++) {
                    var tt = $(label[j]).html();
                    var sp = $(label[j]).next();
                    var t = "";
                    if ($(sp).is("span") == true) {
                        var t = '<span style="padding:0;color:red;margin:0;height:1em;">*</span>';
                        $(label[j]).next("span").remove();
                    }
                    $(label[j]).remove();
                    $(allspan[i]).append('<span style="display:block;font-weight:500;margin:0;width:' + index + 'em;">' + tt + '' + t + '</span>');

                }
            }
        }
    }
});