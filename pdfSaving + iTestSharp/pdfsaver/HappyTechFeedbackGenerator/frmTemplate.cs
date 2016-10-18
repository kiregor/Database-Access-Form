using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace HappyTechFeedbackGenerator
{
    public partial class TemplateForm : Form
    {
        public TemplateForm()
        {
            InitializeComponent();
        }

        //Event handler
        private void frmTemplate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\kwj101\Desktop\ExamplePDF.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            PdfWriter pdf = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            doc.Add(new Paragraph(this.txtTemplateBox.Text));
            doc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\kwj101\Desktop\ExamplePDF.pdf", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            Document doc = new Document();
            PdfWriter pdf = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            doc.Add(new Paragraph("asdsghgfjfdgf"));
            doc.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
