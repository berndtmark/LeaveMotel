module LeaveMotel {
    class DayWidgetController {

    }

    app.component('dayWidget', {
        templateUrl: 'temp.html',
        controller: DayWidgetController,
        bindings: {
            hero: '='
        }
    });
}