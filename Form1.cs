namespace CSharp_TinhToanTrenDaySo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            // Sua code
            errorProvider1.Clear();

            
            if (!double.TryParse(txtStartNum.Text, out _))
            {
                errorProvider1.SetError(txtStartNum, "Phải nhập số thập phân");
                return;
            }
            if (!double.TryParse(txtEndNum.Text, out _))
            {
                errorProvider1.SetError(txtEndNum, "Phải nhập số thập phân");
                return;
            }
            if(string.IsNullOrEmpty(txtStartNum.Text))
            {
                errorProvider1.SetError(txtStartNum, "Phải nhập giá trị vào ô này");
                return;
            }
            if (string.IsNullOrEmpty(txtEndNum.Text))
            {
                errorProvider1.SetError(txtEndNum, "Phải nhập giá trị vào ô này");
                return;
            }
            

            double startNum = Convert.ToDouble(txtStartNum.Text);
            double endNum = Convert.ToDouble(txtEndNum.Text);

            double totalNum = 0, powerNum = 1, totalChan = 0, totalLe = 0;

            for (double i = startNum; i <= endNum; i++)
            {
                totalNum += i;
                powerNum *= i;
                if (i % 2 == 0)
                {
                    // Tổng chẵn
                    totalChan += i;
                } else
                {
                    // Tổng lẻ
                    totalLe += i;
                }
            }

            txtTotal.Text = totalNum.ToString();
            txtPower.Text = powerNum.ToString();
            txtTotalChan.Text = totalChan.ToString();
            txtTotalLe.Text = totalLe.ToString();
        }
    }
}
