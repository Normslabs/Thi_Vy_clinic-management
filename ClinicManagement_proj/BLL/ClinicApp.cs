using ClinicManagement_proj.BLL.Services;
using ClinicManagement_proj.DAL;
using ClinicManagement_proj.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement_proj.BLL {

    // TODO: SUGGESTION
    // Added the ClinicApp class to bootstrap and setup the DbContext and the
    // application services in a clean and organized manner.
    public class ClinicApp {

        private ClinicDbContext context;

        private RoleService roleService;
        private UserService userService;
        private PatientService patientService;
        private DoctorService doctorService;
        private AppointmentService appointmentService;

        private LoginForm loginForm;

        public ClinicApp() { 
            this.context = new ClinicDbContext();
            this.roleService = new RoleService(this.context);
            this.userService = new UserService(this.context, this.roleService);
            this.patientService = new PatientService(this.context);
            this.doctorService = new DoctorService(this.context);
            this.appointmentService = new AppointmentService(this.context);

            this.loginForm = new LoginForm(this.roleService, this.userService, this.patientService, 
                this.doctorService, this.appointmentService);
        }

        public void Run() {
            Application.Run(this.loginForm);
        }

    }
}
