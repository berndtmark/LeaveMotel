var app = angular.module('leaveMotel', []);
//# sourceMappingURL=app.js.map
var LeaveMotel;
(function (LeaveMotel) {
    var LeaveController = (function () {
        function LeaveController(leaveService) {
            this.leaveService = leaveService;
            this.testData = 'success';
        }
        return LeaveController;
    }());
    LeaveController.$inject = ["leaveService"];
    LeaveMotel.LeaveController = LeaveController;
    app.controller("leaveController", LeaveMotel.LeaveController);
})(LeaveMotel || (LeaveMotel = {}));
//# sourceMappingURL=leaveController.js.map
var LeaveMotel;
(function (LeaveMotel) {
    var DayWidgetController = (function () {
        function DayWidgetController() {
        }
        return DayWidgetController;
    }());
    app.component('dayWidget', {
        templateUrl: '/Leave/DayWidget',
        controller: DayWidgetController,
        bindings: {
            name: '='
        }
    });
})(LeaveMotel || (LeaveMotel = {}));
//# sourceMappingURL=dayWidget.js.map
var LeaveMotel;
(function (LeaveMotel) {
    var LeaveCalandar = (function () {
        function LeaveCalandar() {
        }
        return LeaveCalandar;
    }());
    LeaveMotel.LeaveCalandar = LeaveCalandar;
})(LeaveMotel || (LeaveMotel = {}));
//# sourceMappingURL=leaveCalandar.js.map
var LeaveMotel;
(function (LeaveMotel) {
    var LeaveService = (function () {
        function LeaveService(http) {
            this.http = http;
        }
        LeaveService.prototype.getCalandar = function () {
            return null;
        };
        return LeaveService;
    }());
    LeaveService.$inject = ["$http"];
    LeaveMotel.LeaveService = LeaveService;
    app.service("leaveService", LeaveMotel.LeaveService);
})(LeaveMotel || (LeaveMotel = {}));
//# sourceMappingURL=leaveService.js.map