using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class EDITOR : Form
    {
        public EDITOR()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            creaPreview();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            creaPreview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Utente\Desktop\editor\" + textBox1.Text + ".html";
            StreamWriter sw = new StreamWriter(path, true);
            if (!System.IO.File.Exists(path))
            {
                System.IO.File.Create(path);
            
            }

            string css = "<head><link rel='stylesheet' type='text/css' href='" + textBox2.Text + ".css" + "'></head>";
            string html = "<html>" + css + "<body>" + richTextBox1.Text + "</body>" + "</html>";
            sw.Write(html);
            sw.Close();
            string file = @"C:\Users\Utente\Desktop\editor\" + textBox2.Text + ".css";
            StreamWriter s = new StreamWriter(file, true);
            if (!System.IO.File.Exists(file))
            {
                System.IO.File.Create(file);
            }
            s.Write(richTextBox2.Text);
            s.Close();
        }

        private void creaPreview()
        {
            string css = "<head><style>" + richTextBox2.Text + "</style></head>";
            webBrowser1.DocumentText = "<html>" + css + "<body>" + richTextBox1.Text + "</body>" + "</html>";
        }
    }
}