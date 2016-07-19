angular.module("dpFactories")
       .factory("dataAccessFactory", dataAccessFactory);

dataAccessFactory.$inject = ["$resource"];

function dataAccessFactory($resource) {
    var service = {
        get: get,
        post: post,
        put: put,
        remove: remove,
        getMasterCommunicator: getMasterCommunicator,
        getRecommendationCommunicator: getRecommendationCommunicator
    };

    return service;

    function get() {
    }

    function post() {
    }

    function put() {
    }

    function remove() {
    }

    function getMasterCommunicator() {
        var communicator = $resource("http://localhost:54952/api/home", {},
                            {
                                get: { method: "GET" },
                                query: { method: "GET", isArray: true },
                                update: { method: "POST" },
                                save: { method: "POST" },
                                remove: { method: "DELETE" }
                            });

        return communicator;
    }

    function getRecommendationCommunicator() {
        var communicator = $resource("http://localhost:54952/api/recommendation/:action", {},
            {
                fetch: { params: { action: "Fetch" }, method: "POST", isArray: true }

            });
        return communicator;
    }

}
