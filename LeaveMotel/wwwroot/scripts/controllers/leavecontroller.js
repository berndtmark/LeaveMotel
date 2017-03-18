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