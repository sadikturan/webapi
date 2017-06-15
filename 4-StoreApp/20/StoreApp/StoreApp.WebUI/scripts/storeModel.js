var model = {
    products: ko.observableArray([]),
    categories: ko.observableArray([]),
    orders: ko.observableArray([]),
    error: ko.observable(""),
    isError: ko.observable(false)
};

$(document).ready(function () {

    ko.applyBindings();

    setDefaultCallbacks(function (data) {
        if (data) {
            console.log("Begin success");
            console.log(JSON.stringify(data));
            console.log("End success");
        } else {
            console.log("success (veri yok)");
        }
        model.isError(false);
    },
    function (statuscode, statustext) {
        console.log("error : " + statuscode + "(" + statustext + ")");
        model.error(statuscode + " (" + statustext + ")");
        model.isError(true);
    });
});