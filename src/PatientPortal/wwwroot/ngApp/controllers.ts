namespace PatientPortal.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
    }

    export class MDLoginController {
        public message = 'Hello from the about page!';
    }

    export class DashController {
     

        oneAtATime = false;

        groups = [
            {
                title: 'My Account',
                
                content: 'Change Password',
                content2: 'Personal Information'
            },
            {
                title: 'Medical Records',
               
                content: 'Personal Health Record'
            },
            {
                title: 'Messages',
               
                content: 'Inbox',
                content2: 'New Message'
            },
            {
                title: 'Appointments',
                
                content: 'Request New Appointment',
                content2: 'Upcoming Appointments'
            }
        ];


        status = {
            isFirstOpen: true,
            isFirstDisabled: false
        };        
        
    }
    export class PatientRegistrationController {

    }
}
