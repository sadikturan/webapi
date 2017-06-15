var categoryUrl = "http://localhost:61827/api/categories/";

var getCategories = function () {
    sendRequest(categoryUrl + "getCategories", "Get", null, function (data) {
        model.categories.removeAll();
        model.categories.push.apply(model.categories, data);
    })
};

var deleteCategory = function (id) {
    sendRequest(categoryUrl + "DeleteCategory" + "/" + id, "DELETE", null, function () {
        model.categories.remove(function (item) {
            return item.Id == id;
        })
    })
};

var saveCategory = function (category, successCallback) {
    sendRequest(categoryUrl + "PostCategory", "POST", category, function () {
        getCategories();
        if (successCallback) {
            successCallback();
        }
    });
}