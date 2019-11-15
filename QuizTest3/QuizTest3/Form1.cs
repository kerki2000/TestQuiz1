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

namespace QuizTest3
{
    public partial class frmCarWash : Form
    {
        public frmCarWash()
        {
            InitializeComponent();
        }

      

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioCar_CheckedChanged(object sender, EventArgs e)
        {
            groupOwner.Enabled = false;
            groupCar.Enabled = true;
           
        }

        private void radioOwner_CheckedChanged(object sender, EventArgs e)
        {
           
            groupOwner.Enabled = true;
            groupCar.Enabled = false;
        }

        private void cmbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            if (cmbMake.SelectedItem.ToString() == "Honda")
            {
                cmbModel.Items.Add("CRV");
                cmbModel.Items.Add("HRV");
                cmbModel.Items.Add("Accord");
                cmbModel.Items.Add("Civic");
            }
            if (cmbMake.SelectedItem.ToString() == "Toyota")
            {
                cmbModel.Items.Add("Camry");
                cmbModel.Items.Add("RaV4");
                cmbModel.Items.Add("Corolla");
                
            }
            if (cmbMake.SelectedItem.ToString() == "Nissan")
            {
                cmbModel.Items.Add("Rogue");
                cmbModel.Items.Add("Micra");
                cmbModel.Items.Add("Sentra");
                cmbModel.Items.Add("Maxima");
            }
            if (cmbMake.SelectedItem.ToString() == "Subaru")
            {
                cmbModel.Items.Add("Forester");
                cmbModel.Items.Add("Srx");
                cmbModel.Items.Add("Crosstrac");
               
            }
        }

        private void frmCarWash_Load(object sender, EventArgs e)
        {
            cmbMake.Items.Add("Honda");
            cmbMake.Items.Add("Toyota");
            cmbMake.Items.Add("Nissan");
            cmbMake.Items.Add("Subaru");

            cmbYear.Items.Add("2019");
            cmbYear.Items.Add("2018");
            cmbYear.Items.Add("2017");

        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbModel.Text = string.Empty;
            cmbMake.Text = string.Empty;
            cmbYear.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals("") || txtLastName.Text.Equals("") || txtPhone.Text.Equals("")
                ||cmbMake.Text.Equals("") || cmbModel.Text.Equals("") || cmbYear.Text.Equals(""))
            {
                string message = "All fields required";
                MessageBox.Show(message, "WARNING:", MessageBoxButtons.OKCancel);

            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";      
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                    using (System.IO.StreamWriter writeTo = new System.IO.StreamWriter(saveFileDialog1.FileName, true))
                {
                    writeTo.WriteLine("First Name: {0} Last Name: {1} Phone: {2} Car Make: {3} Car Model: {4} Car Year: {5}", txtFirstName.Text,
                        txtLastName.Text, txtPhone.Text,cmbMake.Text, cmbModel.Text, cmbYear.Text);

                }
                MessageBox.Show("Fille Saved", "WARNING:", MessageBoxButtons.OK);
            }
        }
    }
}
