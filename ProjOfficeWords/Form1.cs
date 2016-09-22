
using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;



namespace ProjOfficeWords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //specify the path of ms word docx
            string fileName = @"C:\Users\LinX64\Desktop\ProjOfficeWords\ProjOfficeWords\sample1.docx";
            

            try
            {

                // Create a word Application
                Microsoft.Office.Interop.Word.Application myapp1 = new Microsoft.Office.Interop.Word.Application();
                Document mydoc1;
                //define the word docx
                mydoc1 = myapp1.Documents.Open(fileName);

                // Activate the word docx
                mydoc1.Activate();
                myapp1.Visible = true; // Let's show the output!


                //get all Bookmarks
                Bookmarks bk = mydoc1.Bookmarks;
                bk["dtSubject"].Range.Text = dateTimePicker1.Value.Date.ToString();
                bk["Subject"].Range.Text = txtSubject.Text;
                bk["FullName"].Range.Text = txtTitle.Text;
                bk["Address"].Range.Text = txtAddress.Text;

                MessageBox.Show("Successfull!");

            }

           
            catch (Exception ex)
            {
                MessageBox.Show("UnSuccessfull!");
            }



 }
    
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
