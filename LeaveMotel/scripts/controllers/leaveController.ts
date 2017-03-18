module LeaveMotel {
    
    export class LeaveController {
        testData: string;

        static $inject = ["leaveService"];
        constructor(public leaveService: ILeaveService) {
            this.testData = 'success';
        }
    }
    
    app.controller("leaveController", LeaveMotel.LeaveController);
}