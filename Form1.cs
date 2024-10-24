namespace LOGIN
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo xác nhận trước khi thoát
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes", đóng ứng dụng
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ TextBox
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Kiểm tra thông tin đăng nhập
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
