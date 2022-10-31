namespace ЛР8_ИДЗ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result;
            double x = Convert.ToDouble(textBoxX.Text);
            double y = Convert.ToDouble(textBoxY.Text);
            int n = Convert.ToInt32(textBoxN.Text);
            int r = Convert.ToInt32(textBoxR.Text);

            if (radioButton1.Checked)
            {
                result=Уравнение.Решить1(x, y, n);
            }
            else
            {
                result=Уравнение.Решить2(n, r);
            }
            textBoxResult.Text = result.ToString();
        }
    }
}