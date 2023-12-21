using System.Reflection.Metadata;

namespace Exercicio_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string resultado = "";

            for (int i = 2; i <= 100; i++)
            {
                resultado += $" {i}\n";
            }

            MessageBox.Show(resultado);



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}