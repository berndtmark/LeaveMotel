module LeaveMotel {
    class DayWidgetController {

    }

    app.component('dayWidget', {
        templateUrl: '/Leave/DayWidget',
        controller: DayWidgetController,
        bindings: {
            name: '='
        }
    });
}