using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Calculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        //create array
        List<SS> Liststudents = new List<SS>();

        double GPAS = 0;
        double SUMGPA = 0;
        double totalGPA = 0;
        //ตัวแปร การจำนวนเกรดว่ามีกี่ตัวอะไรบ้าง
        double findgradeA = 0;
        double findgradeB1 = 0;
        double findgradeB2 = 0;
        double findgradeC1 = 0;
        double findgradeC2 = 0;
        double findgradeD1 = 0;
        double findgradeD2 = 0;
        double findgradeF = 0;
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //get input data from texrbox
            string inputID = tbinputid.Text;
            string inputName = tbinputidname.Text;
            string inputScore = tbinputidscore.Text;
            GPAS = double.Parse(inputScore);

            SS Student = new SS();
            Student.name = inputName;
            Student.studentid = inputID;
            Student.score = inputScore;
            Liststudents.Add(Student);

            findMixandminscore();
            findAverage();
            findgrade();
            findGPA();
        }
        //ตัวแปร เพื่อหาจำนวนมากสุดน้อยสุด
        double maxScore = 0;
        double minScore = 0;
        // ตัวเแปร เพือเอาไปหาค่าเฉลี่ยของข้อมูล
        double sumnumscore = 0;
        double averagenumscore = 0;
        void findMixandminscore()
        {
            

            for (int i = 0;i < Liststudents.Count;i++)
            {
                foreach (SS student in Liststudents)
                {
                    double studentScore = double.Parse(student.score);
                    sumnumscore += studentScore;
                    averagenumscore++;
                    if (studentScore > maxScore)
                    {
                        maxScore = studentScore;
                        minScore = studentScore;
                        textboxidmax.Text = student.studentid;
                        textboxnamemax.Text = student.name;
                        textboxscoremax.Text = student.score;

                    }
                    if (studentScore < maxScore)
                    {
                        if (studentScore < minScore)
                        {
                            minScore = studentScore;
                            textboxidmin.Text = student.studentid;
                            textboxnamemin.Text = student.name;
                            textboxscoremin.Text = student.score;
                        }
                    }


                }
            }
        }
        
        // หาค่าเฉลี่ยสุดสุดต่ำสุด
        void findAverage()
        {
            double total = sumnumscore / averagenumscore;
            total111.Text = total.ToString();
        }
        //หาผมรวมของเกรด
        double sumnumGPA = 0;
        //หาขอมูลaverageไปคำนวน
        double averagenumGPA = 0;
        void findgrade()
        {
            averagenumGPA += 3;
            if (GPAS < 50)
            {
                findgradeF++;
                textBoxF.Text = findgradeF.ToString();
                double x = 0;
                sumnumGPA += x;
            }
            if (GPAS >= 50 && GPAS < 55)
            {
                findgradeD2++;
                textBoxD2.Text = findgradeD2.ToString();
                double x = 1;
                sumnumGPA += x;
                
            }
            if (GPAS >= 55 && GPAS < 60)
            {
                findgradeD1++;
                textBoxD1.Text = findgradeD1.ToString();
                double x = 1.5;
                sumnumGPA += x;
            }
            if (GPAS >= 60 && GPAS < 65)
            {
                findgradeC2++;
                textBoxC2.Text = findgradeC2.ToString();
                double x = 2;
                sumnumGPA += x;
            }
            if (GPAS >= 65 && GPAS < 70)
            {
                findgradeC1++;
                textBoxC1.Text = findgradeC1.ToString();
                double x = 2.5;
                sumnumGPA += x;
            }
            if (GPAS >= 70 && GPAS < 75)
            {
                findgradeB2++;
                textBoxB2.Text = findgradeB2.ToString();
                double x = 3;
                sumnumGPA += x;
            }
            if (GPAS >= 75 && GPAS < 80)
            {
                findgradeB1++;
                textBoxB1.Text = findgradeB1.ToString();
                double x = 3.5;
                sumnumGPA += x;
            }
            if (GPAS >= 80)
            {
                findgradeA++;
                textBoxA.Text = findgradeA.ToString();
                double x = 4;
                sumnumGPA += x;
            }

        }

        // หาเกรดเฉลี่ยรวม
        void findGPA()
        {
            double sum = sumnumGPA * 3;
            double total = sum / averagenumGPA;
            textBoxGPA.Text = total.ToString();

        }


    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
