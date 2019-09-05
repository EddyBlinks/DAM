using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


// Login Form
namespace LoginForm
{
    public partial class LoginForm : Form
    {
        //Conncection String variable for Database
        string connectionString = @"Data Source=(LocalDb)\LoginProject;Initial Catalog=ProLogin;Integrated Security=True";
        public string userID;

        // Program Start Login form Initialize Component
        #region
        public LoginForm()
        {
            
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        #endregion


        // Clear textBoxes
        #region


        //Method to Clear Login cursor Space
        void ClearLoginForm()
        {
            textBoxUsername.Text = string.Empty; ;
            textBoxPassword.Text = string.Empty;

        }

        //Method to clear Sign Up Cursor Spaces
        void ClearSignupForm()
        {
            textBoxFirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxUsername.Text = string.Empty;
            textBoxPassword.Text = string.Empty;

        }
        #endregion

        
        //Method To Login
        #region
        public void LoginMethod()
        {
            using(SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "select UserID from Table_Login where Username = '" + textBoxUsername.Text.Trim() + "' and Password = '" + textBoxPassword.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                SqlDataReader rd = null;
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    userID = string.Format("{0}", rd["UserID"].ToString());
                }

                rd.Close();

                if (dtbl.Rows.Count == 1)
                {
                    DashboardForm df = new DashboardForm(userID);
                    this.Hide();
                    df.Show();
                }
                else
                {
                    MessageBox.Show("Please check Username and Password");
                    ClearLoginForm();
                }

            }
        }
        
        //Btn to Login
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginMethod();       
        }

        #endregion


        //Method To Sign Up
        #region       
        public void SignupMethod()
        {
           
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
               if (textBoxUsernameSignUp.Text == "" || textBoxPasswordSignUp.Text == "")

                    MessageBox.Show("Please fill Mandatory fields");

                else
                {
 
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("addUser", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", textBoxUsernameSignUp.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", textBoxPasswordSignUp.Text.Trim());

                    sqlCmd.ExecuteNonQuery();                           

                    string queryUSerID = "select UserID from Table_Login where FirstName = '" + textBoxFirstName.Text.Trim() + "'" +
                        " and LastName = '" + textBoxLastName.Text.Trim() + "' and Username = '" + textBoxUsernameSignUp.Text.Trim() + "'";
                    SqlDataReader rd = null;
                    SqlCommand cmd = new SqlCommand(queryUSerID, sqlCon);
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        userID = string.Format("{0}", rd["UserID"].ToString());
                    }

                    rd.Close();

                    MessageBox.Show("User Added");                

                }               
                    ClearSignupForm();

            }
           
        }

        //Sign Up Btn
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            SignupMethod();
            
        }

        #endregion

        // Exit Buttons on Login and SignUp Screen
        #region
        // Exit Btn on Login Screen
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Exit Button on SignUp Screen
        private void BtnExitSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
