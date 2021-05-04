using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbcompta.VIEWS
{
    public partial class AddUser : Form
    {
        String Id;
        String NameUser;
        String Firstname;
        String Login;
        String Password;
        String Address;
        String Zip;
        String City;
        String DateEmployment;
        String Role;

        ListeFiches form;
        UserController uController;

        public AddUser()
        {
            InitializeComponent();

        }
        public AddUser(string id, string name, string firstname, string login, string password, string address, string zip, string city, string dateEmployment, string role)    
        {
            InitializeComponent();

            this.Id = id;
            this.NameUser = name;
            this.Firstname = firstname;
            this.Login = login;
            this.Password = password;
            this.Address = address;
            this.Zip = zip;
            this.City = city;
            this.DateEmployment = dateEmployment;
            this.Role = role;

            this.txtId.Text = Id;
            this.txtName.Text = NameUser;
            this.txtFirstname.Text = Firstname;
            this.txtLogin.Text = Login;
            this.txtPsw.Text = Password;
            this.txtAddress.Text = Address;
            this.txtCp.Text = Zip;
            this.txtCity.Text = City;
            this.dateTimePicker1.Text = DateEmployment;
            this.txtRole.Text = Role;

            uController = new UserController();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            DateTime dateValue = Convert.ToDateTime(this.dateTimePicker1.Value);
            string date = dateValue.ToString("yyyy-MM-dd");

            String id = this.txtId.Text;
            String name = this.txtName.Text;
            String firstname = this.txtFirstname.Text;
            String login = this.txtLogin.Text;
            String password = this.txtPsw.Text;
            String address = this.txtAddress.Text;
            String zip = this.txtCp.Text;
            String city = this.txtCity.Text;            
            String role = this.txtRole.Text;

            uController = new UserController();

            uController.addUsers(id, name, firstname, login, password, address, zip, city, date, role) ;
            this.Close();
            form = new ListeFiches();
            form.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            form = new ListeFiches();
            form.Show();
            this.Hide();
        }
    }
}
