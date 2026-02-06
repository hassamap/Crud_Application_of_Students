using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Application
{
    public partial class Form1 : Form
    {
        studentDBDataContext db;
        public Form1()
        {
            InitializeComponent();
        }
        private void Display_Data()
        {
            db = new studentDBDataContext();
            dataGridView1.DataSource = db.students;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Display_Data();
        }
        private void Cleartextbox() {

            foreach (Control ctr in this.Controls )
            {
                if (ctr is TextBox) {
                    TextBox txt = ctr as TextBox;
                    txt.Clear();
                     NAMEtextBox.Focus();

                }
            }
        
        }
        private void INSERTbutton_Click(object sender, EventArgs e)
        {
            if ( NAMEtextBox.Text == "" || AGEtextBox.Text == "" || STANDARDtextBox.Text == ""  ||  GENDERtextBox.Text == ""    ) {
                MessageBox.Show("Please fill all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
  
          


            else { 
                student std_lst = new student();
            std_lst.Name = NAMEtextBox.Text;
            std_lst.Gender =GENDERtextBox.Text;
            std_lst.Age = int.Parse(AGEtextBox.Text);
            std_lst.Standard = int.Parse(STANDARDtextBox.Text);
            db.students.InsertOnSubmit(std_lst);
            db.SubmitChanges();
            MessageBox.Show( "Record submited", "Successfully" , MessageBoxButtons.OK, MessageBoxIcon.Information);

            Cleartextbox();
                Display_Data();
                NAMEtextBox.Focus();
            }
        }

        private void CLEARbutton_Click(object sender, EventArgs e)
        {
            Cleartextbox();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            db = new studentDBDataContext();

             

                NAMEtextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                AGEtextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                GENDERtextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                STANDARDtextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            
                }

        private void UPDATEbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id_no = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                student std_lst = db.students.FirstOrDefault(s => s.Id == id_no);
                std_lst.Name = NAMEtextBox.Text;
                std_lst.Age = int.Parse(AGEtextBox.Text);
                std_lst.Gender = GENDERtextBox.Text;
                std_lst.Standard = int.Parse(STANDARDtextBox.Text);
                db.SubmitChanges();
                MessageBox.Show("Record Updated", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cleartextbox();
                Display_Data();
            }
            else { 
            
            MessageBox.Show("No data is selected ","Select a data from below ", MessageBoxButtons.OK,MessageBoxIcon.Information );
            }

        }

        private void DELbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id_no = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                student std_lst = db.students.FirstOrDefault(s => s.Id == id_no);
                db.students.DeleteOnSubmit(std_lst);
                db.SubmitChanges();
                MessageBox.Show("Record Deleted", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                Cleartextbox();
                Display_Data();
             //   NAMEtextBox.Focus();
            }
            else
            {
                MessageBox.Show("No data is selected ", "Select a data from below ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }
    }
}
