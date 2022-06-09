using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class ContactTracing : Form
    {
        public ContactTracing()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\barbacena\Documents\VisualStudioCTA\CTresponse.txt", true);
            file.WriteLine("Response of Client " + txtboxLN.Text);
            file.WriteLine("First Name: " + txtboxFN.Text);
            file.WriteLine("Middle Name: " + txtboxMN.Text);
            file.WriteLine("Last Name: " + txtboxLN.Text);
            file.WriteLine("Suffix: " + txtboxSuffix.Text);
            file.WriteLine("Birth Date: " + txtboxbirthdate.Text);
            file.WriteLine("Age: " + txtboxage.Text);
            file.WriteLine("Gender: " +txtboxgender.Text);
            file.WriteLine("Civil Status: " + txtboxcivilstatus.Text);
            file.WriteLine("Region:" + txtboxRegion.Text);
            file.WriteLine("City: " + txtboxCity.Text);
            file.WriteLine ("Street Name: " + txtboxStreet.Text);
            file.WriteLine ("Barangay: " + txtboxBarangay.Text);
            file.WriteLine ("Email Address:" + txtboxEmailAdd.Text);
            file.WriteLine ("Mobile Number:" + txtboxMobileNum.Text);
            file.WriteLine ("Telephone Number:" + txtboxTelephonNum.Text);
            file.WriteLine ("" + );
            file.WriteLine ("" + );
            file.WriteLine ("" + );
            file.WriteLine ("" + );
            file.WriteLine ("" + );
            file.Close();
        }
    }
}
