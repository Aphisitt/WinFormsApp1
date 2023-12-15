namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Student1231> List_student1 = new List<Student1231>();
        Student1231 student1;

        string iDstudent;
        string namEstudent;
        double scorEstudent;

        double[] Gradeall = new double[7];

        int[] numGrade = new int[8];

        private void button1_Click(object sender, EventArgs e)
        {
            //ทุกอย่างจะเขียนในนี้
            iDstudent = textBox4.Text;
            namEstudent = textBox3.Text;
            scorEstudent = double.Parse(textBox2.Text);

            student1 = new Student1231();
            student1.Name = namEstudent = textBox3.Text;
            student1.Studentid = iDstudent;
            student1.Score = scorEstudent;

            List_student1.Add(student1);

            double max = 0;
            foreach (Student1231 i in List_student1)
            {
                if (i.Score > max)
                {
                    max = i.Score;
                    textBox14.Text = i.Studentid;
                    textBox16.Text = i.Name;
                    textBox18.Text = i.Score.ToString();
                }

            }

            double min = max;
            foreach (Student1231 i in List_student1)
            {

                if (i.Score < min)
                {
                    min = i.Score;
                    textBox13.Text = i.Studentid;
                    textBox15.Text = i.Name;
                    textBox17.Text = i.Score.ToString();

                }
            }
            double sum_score = 0;
            foreach (Student1231 i in List_student1)
            {
                sum_score += i.Score;
            }
            double count_num = List_student1.Count;
            textBox19.Text = (sum_score / count_num).ToString();

            if (scorEstudent >= 80 && scorEstudent <= 100)
            // เกรดA
            {
                numGrade[0]++;
                textBox6.Text = numGrade[0].ToString();
                Gradeall[0] = numGrade[0] * 4;

            }
            else if (scorEstudent >= 75 && scorEstudent <= 75)
            // เกรดB+
            {
                numGrade[1]++;
                textBox5.Text = numGrade[1].ToString();
                Gradeall[1] = numGrade[1] * 3.5;
            }
            else if (scorEstudent >= 70 && scorEstudent <= 74)
            // เกรดB
            {
                numGrade[2]++;
                textBox1.Text = numGrade[2].ToString();
                Gradeall[2] = numGrade[2] * 3;
            }
            else if (scorEstudent >= 65 && scorEstudent <= 69)
            //เกรดC+
            {
                numGrade[3]++;
                textBox9.Text = numGrade[3].ToString();
                Gradeall[3] = numGrade[3] * 2.5;

            }
            else if (scorEstudent >= 60 && scorEstudent <= 64)
            //เกรดC
            {
                numGrade[4]++;
                textBox7.Text = numGrade[4].ToString();
                Gradeall[4] = numGrade[4] * 2;
            }
            else if (scorEstudent >= 55 && scorEstudent <= 59)
            //เกรดD+
            {
                numGrade[5]++;
                textBox8.Text = numGrade[5].ToString();
                Gradeall[5] = numGrade[5] * 1.5;
            }
            else if (scorEstudent >= 50 && scorEstudent <= 54)
            //เกรดD
            {
                numGrade[6]++;
                textBox12.Text = numGrade[6].ToString();
                Gradeall[6] = numGrade[6] * 1;

            }
            else
            //เกรดF
            {
                numGrade[7]++;
                textBox10.Text = numGrade[7].ToString();
            }

            double resultScore = 0;
            foreach (double i in Gradeall)
            {
                resultScore += i;
            }

            double CalculateGPA = resultScore / List_student1.Count;

            textBox11.Text = CalculateGPA.ToString();

}


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
