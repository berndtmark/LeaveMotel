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