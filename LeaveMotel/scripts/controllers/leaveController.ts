module LeaveMotel {
    
    export class LeaveController {
        testData: string;

        //static $inject = ["$scope", "$http"];
        constructor() {
            this.testData = 'success';
        }
    }
    
    app.controller("leaveController", LeaveMotel.LeaveController);
}