angular.module("dpFactories")
       .factory("loggerFactory", loggerFactory);

loggerFactory.$inject = ["$log"];

function loggerFactory($log) {
    var service = {
        logMessage: logMessage
    };

    return service;

    function logMessage(message) {
        $log.log("Principle: ", message);
    }
}
