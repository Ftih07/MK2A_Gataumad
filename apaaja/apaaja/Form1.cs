using System.Security.Policy;

namespace apaaja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                int numA = 0;
                int numB = 0;
                int numC = 0;

                // Memeriksa input benar benar angka le
                bool isNumericA = int.TryParse(txtA.Text, out numA);
                bool isNumericB = int.TryParse(txtB.Text, out numB);
                bool isNumericC = int.TryParse(txtC.Text, out numC);

                // Jika semua input valid
                if (isNumericA && isNumericB && isNumericC)
                {
                    // Menghindari pembagian dengan nol
                    if (numB != 0)
                    {
                        // Melakukan operasi pembagian dan pemangkatan
                        double hasil = Math.Pow((double)numA / numB, numB * numC);

                        // Menampilkan hasil di txthasil (dengan tipe double)
                        txthasil.Text = hasil.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Pembagi (B) tidak boleh nol", "Kesalahan Input");
                    }
                }
                else
                {
                    MessageBox.Show("Angka yang kamu masukkan tidak valid", "Kesalahan Input");
                }
            

        }
    }
}
