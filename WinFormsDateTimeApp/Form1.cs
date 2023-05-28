namespace WinFormsDateTimeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Image image = Image.FromFile(@"X:\RPO\maxim efimov\bg.jpg");
            pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            DateTime dt = monthCalendar1.SelectionStart;
            while (dt <= monthCalendar1.SelectionEnd)
            {
                str += dt.ToLongDateString() + "\n";
                dt = dt.AddDays(1);
            }
            MessageBox.Show(str);
        }
    }
}