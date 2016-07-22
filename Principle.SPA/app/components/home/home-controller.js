(function () {

    angular
        .module("dpDesign")
        .controller("HomeController", HomeController);

    HomeController.$inject = ["$location", "dataAccessFactory"];

    function HomeController($location, factory, $http) {

        var that = this;
        that.title = "Entities";
        that.newEntity = "";
        that.entities = [];
        that.recommendations = [];
        that.add = add;
        that.remove = remove;
        that.getRecommendation = getRecommendation;

        activate();

        function activate() {
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

        function add() {
            that.entities.push({ Name: that.newEntity });
            that.newEntity = "";
        }

        function remove(entity) {
            var index = that.entities.indexOf(entity);
            that.entities.splice(index, 1);
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
