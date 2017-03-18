module LeaveMotel {
    export interface ILeaveService {
        getCalandar(): LeaveCalandar;
    }

    export class LeaveService implements ILeaveService {
        static $inject = ["$http"];
        constructor(public http: ng.IHttpService) {
           
        }

        getCalandar(): LeaveCalandar {
            return null;
        }
    }
    
    app.service("leaveService", LeaveMotel.LeaveService);
}