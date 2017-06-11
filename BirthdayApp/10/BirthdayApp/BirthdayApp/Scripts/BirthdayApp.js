var model =
{
    view: ko.observable("hosgeldin"),
    davetiyeModel: {
        Ad: ko.observable(""),
        Eposta: ko.observable(""),
        katilmaDurumu: ko.observable("true")
    },
    Katilanlar: ko.observableArray([])
}

var formuGoster = function () {
    model.view("form");
}

var formuGonder = function () {
    $.ajax("/api/Davetiye/Ekle",
        {
            type: "POST",
            data: {
                Ad: model.davetiyeModel.Ad,
                Eposta: model.davetiyeModel.Eposta,
                KatilmaDurumu: model.davetiyeModel.katilmaDurumu
            },
            success: function () {
                katilanlariGetir();
            }

        });
}

var katilanlariGetir = function () {

    $.ajax("/api/Davetiye/GetKatilanlar", {
        type: "GET",
        success: function (data) {
            model.Katilanlar.removeAll();
            model.Katilanlar.push.apply(model.Katilanlar, data.map(function (item) {
                return item.Ad;
            }));
            model.view("Thanks");
        }
    });

}

$(document).ready(function () {
    ko.applyBindings();
});