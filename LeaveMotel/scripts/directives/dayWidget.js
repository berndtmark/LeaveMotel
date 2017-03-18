var LeaveMotel;
(function (LeaveMotel) {
    var DayWidgetController = (function () {
        function DayWidgetController() {
        }
        return DayWidgetController;
    }());
    app.component('dayWidget', {
        templateUrl: 'temp.html',
        controller: DayWidgetController,
        bindings: {
            hero: '='
        }
    });
})(LeaveMotel || (LeaveMotel = {}));
//# sourceMappingURL=dayWidget.js.map