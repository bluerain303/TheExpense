function showExpenseGrid() {
    $("#expenseGrid").jqGrid(
        {
            caption: paramFromView.Caption,
            colNames: [
                    "ID",
                    paramFromView.Payer,
                    paramFromView.Payee,
                    paramFromView.Amount,
                    paramFromView.Currency,
                    paramFromView.Actions
            ],
            colModel: [
                    { name: "ID", width: 1, hidden: true, key: true },
                    { name: "Payer", index: "Payer.FirstName" },
                    { name: "Payee", index: "Payee.FirstName" },
                    { name: "Amount", index: "Amount" },
                    { name: "Currency", index: "Currency" },
                    { name: "Actions", index: "ID" }
            ],

            hidegrid: false,
            sortname: "ID",
            rowNum: 10,
            rowList: [10, 20, 50, 100],
            sortorder: "desc",
            width: paramFromView.Width,
            height: paramFromView.height,
            datatype: "json",
            viewrecords: true,
            mType: "GET",
            jsonReader: {
                root: "rows",
                page: "page",
                total: "total",
                records: "records",
                repeatitems: false,
                userdata: "userdata"
            },
            url: paramFromView.Url
        }
    );
};

$(document).ready(function () {
    showExpenseGrid();
});

