var now_C;

(function () {

    var placeJson = JSON.parse($("#X_Y").val());
    for (var i = 0; i < placeJson.length; i++) {
        AddFolw(placeJson[i].Id, $("#menu_" + placeJson[i].Id).text(), placeJson[i].X, placeJson[i].Y);
    }




    $('.MenuBtn').draggable({
        revert: true,
        proxy: 'clone',
        start: function () {
            $(this).draggable('options').cursor = 'not-allowed';
            $(this).draggable('proxy').css('z-index', 10);
        },
        stop: function (event, ui) {
            $(this).draggable('options').cursor = 'move';
            var d = ui.offset;
            var nodeID = $(this).attr('nodeID');
            var _left = d.left  - parseInt($("#page_man").css("left").replace('px', ''));
            var _top = d.top - parseInt($("#page_man").css("top").replace('px', ''));
            
            AddFolw(nodeID, $(this).text(), _left, _top)
            
            setJsPlumb($(".w"));
        }
    });


    window.jsPlumbDemo = {

        init: function () {

            // setup some defaults for jsPlumb.	
            jsPlumb.importDefaults({
                DragOptions: { cursor: "pointer", zIndex: 2000 },
                HoverClass: "connector-hover",
                Endpoint: ["Dot", { radius: 2 }],
                ConnectionOverlays: [
					["Arrow", {
					    location: 1,
					    id: "arrow",
					    length: 14,
					    foldback: 0.8
					}],
	                ["Label", { label: "FOO", id: "label", cssClass: "aLabel" }]
                ]

            });
            setJsPlumb($(".w"));

        }
    };
})();
function setJsPlumb(obj)
{

    jsPlumb.draggable(obj);

    jsPlumb.makeSource(obj, {
        filter: ".ep",				// only supported by jquery
        anchor: "Continuous",
        connector: ["StateMachine", { curviness: 20 }],
        connectorStyle: { strokeStyle: "#5c96bc", lineWidth: 2, outlineColor: "transparent", outlineWidth: 4 },
        maxConnections: 5,
        onMaxConnections: function (info, e) {
            alert("Maximum connections (" + info.maxConnections + ") reached");
        }
    });

    jsPlumb.makeTarget(obj, {
        dropOptions: { hoverClass: "dragHover" },
        anchor: "Continuous"
    });
    
}

function onSubmit() {


    var t = jsPlumb.getConnections();
    var allChild = $("#page_man").children(".w")
    var x_y = [];
    for (var i = 0; i < allChild.length; i++)
    {
        var doc = $(allChild[i])
        var t = {
            Id: doc.attr('id').replace('NODE_',''),
            Y: doc.position().top,
            X: doc.position().left
        }
        x_y[x_y.length] = t;

    }
    var jsonObjStr = JSON.stringify(x_y)
    $("#X_Y").val(jsonObjStr)
    var com = $(".combo-text")
    if (com.attr('name') == null) {
        com.attr('name', 'combo_text')
    }

    var obj = $('input[type="submit"]');
    obj[0].click()
}

function AddFolw(nodeID, text, left, top)
{
    if ($("#NODE_" + nodeID).html() == null) {
        if (left > 0 && top > 0) {
            var str = '<div class="w" id="NODE_' + nodeID + '" style="top:' + top + 'px;left:' + left + 'px">' + text + '<div class="ep"></div>';
            $(str).appendTo($("#page_man"));
        }
    }
}

function SaveNode()
{
    var jsonObj = JSON.parse($("#FlowListStr").val());
    for (var i = 0; i < jsonObj.length; i++) {
        if (jsonObj[i].FROM_FLOWNODE_ID == $("#FROM_FLOWNODE_ID").val() && jsonObj[i].TO_FLOWNODE_ID == $("#TO_FLOWNODE_ID").val()) {
            jsonObj[i].HANDLE=$("#HANDLE").val();
            jsonObj[i].STATUS=$("#STATUS").val();
            jsonObj[i].REMARK = $("#REMARK").val();
            jsonObj[i].AllRoleStr = $("#AllRoleStr").val();
            break;
        }
    }
    $("#FlowListStr").val(JSON.stringify(jsonObj));
    now_C.getOverlay("label").setLabel(jsonObj[i].STATUS);
    $.messager.alert('提示','保存成功','info');
    $('#editNodeFolw').dialog('close')
}

function DelNode() {
    $.messager.confirm('确认', '您确信要删除本记录?', function (r) {
        if (r) {
            jsPlumb.detach(now_C);
            return;
        }
    });
}


function AllRoleStr_setCheck(name) {
    var strArr = $("#" + name).val().split(',');
    for (var i = 0; i < strArr.length; i++)
    {
        $("input[name='" + name + "_JSITEM']").each(function () {
            if ($(this).val() == strArr[i]) {
                $(this).attr("checked",'checked')
            }
        })
    }
}
jsPlumb.bind("ready", function () {

    // render mode
    var resetRenderMode = function (desiredMode) {
        var newMode = jsPlumb.setRenderMode(desiredMode);
        jsPlumbDemo.init();
    };

    resetRenderMode(jsPlumb.SVG);

    var FlowList = JSON.parse($("#FlowListStr").val());
    for (var i = 0; i < FlowList.length; i++) {

        jsPlumb.connect({
            source: "NODE_" + FlowList[i].FROM_FLOWNODE_ID,
            target: "NODE_" + FlowList[i].TO_FLOWNODE_ID,
            label: FlowList[i].STATUS,
            labelStyle: {
                cssClass: "aLabel"
            }
        });
    }

    jsPlumb.bind("dblclick", function (connection, originalEvent) {
        now_C = connection;
        var jsonObj = JSON.parse($("#FlowListStr").val());
        var isExist = false;
        for (var i = 0; i < jsonObj.length; i++)
        {
            if ("NODE_" + jsonObj[i].FROM_FLOWNODE_ID == connection.sourceId && "NODE_" + jsonObj[i].TO_FLOWNODE_ID == connection.targetId) {
                $("#FROM_FLOWNODE_ID").val(jsonObj[i].FROM_FLOWNODE_ID);
                $("#TO_FLOWNODE_ID").val(jsonObj[i].TO_FLOWNODE_ID);
                $("#HANDLE").val(jsonObj[i].HANDLE);
                $("#STATUS").val(jsonObj[i].STATUS);
                $("#REMARK").val(jsonObj[i].REMARK);
                $("#AllRoleStr").val(jsonObj[i].AllRoleStr);
                AllRoleStr_setCheck('AllRoleStr');
                isExist = true;
                break;
            }
        }
        if (!isExist) {
            jsPlumb.detach(connection);
        }
        else {
            $('#editNodeFolw').dialog('open')
        }
        //$("#FlowListStr").val(JSON.stringify(jsonObj));
        //alert("double click on connection from " + connection.sourceId + " to " + connection.targetId);
    });

    jsPlumb.bind("connection", function (connection, originalEvent) {
        connection.connection.getOverlay("label").setLabel(connection.connection.id);
        now_C = connection;
        var jsonObj = JSON.parse($("#FlowListStr").val());
        var isAdd = true;
        for (var i = 0; i < jsonObj.length; i++) {
            if ("NODE_" + jsonObj[i].FROM_FLOWNODE_ID == connection.sourceId && "NODE_" + jsonObj[i].TO_FLOWNODE_ID == connection.targetId) {
                isAdd = false;
                connection.connection.getOverlay("label").setLabel(jsonObj[i].STATUS);
                break;
            }
        }
        if (isAdd)
        {
            var t = {
                FROM_FLOWNODE_ID: connection.sourceId.replace('NODE_', ''),
                TO_FLOWNODE_ID: connection.targetId.replace('NODE_', ''),
                HANDLE: '0',
                STATUS: connection.connection.id,
                REMARK: ''
            }
            jsonObj[jsonObj.length] = t;
        }
        $("#FlowListStr").val(JSON.stringify(jsonObj));
    });
    jsPlumb.bind("connectionDetached", function (connection, originalEvent) {
        now_C = connection;
        var jsonObj = JSON.parse($("#FlowListStr").val());
        var tmp = [];
        for (var i = 0; i < jsonObj.length; i++) {
            if ("NODE_" + jsonObj[i].FROM_FLOWNODE_ID == connection.sourceId && "NODE_" + jsonObj[i].TO_FLOWNODE_ID == connection.targetId) {

            }
            else {
                tmp[tmp.length] = jsonObj[i];
            }
        }
        $("#FlowListStr").val(JSON.stringify(tmp));
        $('#editNodeFolw').dialog('close')

    });

    jsPlumb.bind("contextmenu", function (component, originalEvent) {
        //alert("context menu on component " + component.id);
        originalEvent.preventDefault();
        return false;
    });
    jsPlumb.bind("click", function (c) {
        //jsPlumb.detach(c);
    });


});