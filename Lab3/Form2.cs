using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab3
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        List<Discipline> listOfDisciplines = new List<Discipline>();
        List<Discipline> listSearchLectorNameToSave = new List<Discipline>();
        string pathToSaveResult = @"D:\\4sem\\OOP\\labs\\Lab3\\Lab3\\Lab3\\searchLectorName.xml";

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            listOfDisciplines = form1.listOfDisciplines;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTransfer.lectorSearch = richTextBox1.Text;
            XmlSerializer formatter = new XmlSerializer(typeof(List<Discipline>));
            string searchLectorOut = "==============================================\n\n";
            string lectorSearch = DataTransfer.lectorSearch;
            List<Discipline> lectorList = new List<Discipline>();

            string pattern = $".*{Regex.Escape(lectorSearch)}.*"; // Регулярное выражение для поиска вхождения

            var res = listOfDisciplines.Where(d => Regex.IsMatch(d.lector.Name, pattern, RegexOptions.IgnoreCase));

            foreach (Discipline dis in res)
                searchLectorOut += dis.ToString();

            MessageBox.Show(searchLectorOut);

            listSearchLectorNameToSave = res.ToList();

            using (FileStream fs = new FileStream(pathToSaveResult, FileMode.Create))
            {
                formatter.Serialize(fs, listSearchLectorNameToSave);
            }

            Close();
        }
    }
}