(function () {

    angular
        .module("dpDesign")
        .controller("HomeController", HomeController);

    HomeController.$inject = ["$location", "dataAccessFactory", "$http"];

    function HomeController($location, factory, $http) {

        var that = this;
        that.title = "Entities";
        that.entities = [];
        that.recommendations = [];
        that.getRecommendation = getRecommendation;

        activate();

        function activate() {
            debugger
            factory
                .getMasterCommunicator()
                .query(
                    function (response) {
                        // success
                        that.entities = response;
                    },
                    function (error) {
                        // fail
                        alert("Error");
                    });
        }

        function getRecommendation() {
            factory
                .getRecommendationCommunicator()
                .fetch(that.entities,
                    function (response) {
                        // success
                        that.recommendations = response;
                    },
                    function (error) {
                        // fail
                        alert("Error");
                    });
        }
        
    }
})();
