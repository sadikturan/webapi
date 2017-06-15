var ordersUrl = "http://localhost:61827/api/orders/";

var getOrders = function () {
    sendRequest(ordersUrl + "getorders", "Get", null, function (data) {
        model.orders.removeAll();
        model.orders.push.apply(model.orders, data);
    })
};

var deleteOrder = function (id) {
    sendRequest(ordersUrl + "DeleteOrder" + "/" + id, "DELETE", null, function () {
        model.orders.remove(function (item) {
            return item.Id == id;
        })
    })
};

var saveOrder = function (order, successCallback) {
    sendRequest(ordersUrl + "PostOrder", "POST", order, function () {
        getOrders();
        if (successCallback) {
            successCallback();
        }
    });
}