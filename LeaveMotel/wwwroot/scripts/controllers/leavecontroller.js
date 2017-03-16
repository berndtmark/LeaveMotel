var LeaveMotel;
(function (LeaveMotel) {
    var LeaveController = (function () {
        //static $inject = ["$scope", "$http"];
        function LeaveController() {
            this.testData = 'success';
        }
        return LeaveController;
    }());
    LeaveMotel.LeaveController = LeaveController;
    app.controller("leaveController", LeaveMotel.LeaveController);
})(LeaveMotel || (LeaveMotel = {}));
//# sourceMappingURL=leavecontroller.js.map