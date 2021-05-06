using Scheduler.Source;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class AddUserForm : Form
    {
        AdminForm adminForm;

        public AddUserForm()
        {
            InitializeComponent();
        }


        public void Open(AdminForm adminForm)
        {
            this.adminForm = adminForm;
            this.Show();
        }


        /// <summary>
        /// Validates if the fields are correctly filled
        /// </summary>
        private bool ValidateAddUser(params string[] inputFields)
        {
            bool valid = true;
            for (int i = 0; i < inputFields.Length; i++)
            {
                if (inputFields[i] == "")
                {
                    valid = false;
                    break;
                }
            }

            return valid;
        }

        /// <summary>
        /// Tries to create a new user from inputted data and writes it to the save file
        /// </summary>
        private void Add_AddUser_Click(object sender, System.EventArgs e)
        {
            string sign = SignInput_AddUser.Text;
            string employeeNr = UserNrInput_AddUser.Text;
            string firstName = FirstNameInput_AddUser.Text;
            string lastName = LastNameInput_AddUser.Text;
            string domain = DomainInput_AddUser.Text;

            if (ValidateAddUser(sign, employeeNr, domain))
            {
                SaveLoad.AppendData(new UserData(sign, employeeNr, firstName, lastName, domain));
                MessageBox.Show($"Användare tillagd!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();

                adminForm.RefreshUsers();
                adminForm.calForm.AddUsers();
            }
            else
            {
                MessageBox.Show($"Fyll i alla fält", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void ClearFields()
        {
            SignInput_AddUser.Text = "";
            UserNrInput_AddUser.Text = "";
            FirstNameInput_AddUser.Text = "";
            LastNameInput_AddUser.Text = "";
            DomainInput_AddUser.Text = "";
        }

        private void Cancel_AddUser_Click(object sender, System.EventArgs e)
        {
            this.Close();
            adminForm.Focus();
        }
    }
}
