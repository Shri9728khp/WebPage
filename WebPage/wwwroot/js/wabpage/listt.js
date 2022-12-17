$(document).ready(function () {
    var exportFlag = false;

    $("#grid").data("kendoGrid").bind("pdfExport", function (e) {
        if (!exportFlag) {
            e.sender.hideColumn(4);
            e.preventDefault();
            exportFlag = true;

            e.sender.saveAsPDF().then(function () {
                e.sender.showColumn(4);
                exportFlag = false;
            });

        }
    });
});