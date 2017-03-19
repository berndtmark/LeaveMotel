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