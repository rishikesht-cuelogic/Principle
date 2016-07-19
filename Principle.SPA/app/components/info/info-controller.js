(function () {

    angular
        .module("dpDesign")
        .controller("InfoController", InfoController);

    InfoController.$inject = ["$location", "dataAccessFactory"];

    function InfoController($location, factory) {

        var that = this;
        that.title = "Levenshtein Distance Algorithm";
    }
})();
