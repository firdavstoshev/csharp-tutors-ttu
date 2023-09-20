using ClassLibraryIT;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 2;
            int b = 3;
            Calc calc= new Calc();
            MessageBox.Show($"{calc.Sum(a, b)}");
        }
    }
}