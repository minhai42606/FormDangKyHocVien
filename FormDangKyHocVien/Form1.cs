using MySql.Data.MySqlClient;

namespace FormDangKyHocVien
{
    public partial class Form1 : Form
    {
        string connectionString ="Server=localhost;" +"Port=3306;" +"Database=quanlyhocvien;" +"Uid=root;" +"Pwd=123456789;" +"CharSet=utf8mb4;";
        private List<Course> courses = new List<Course>();
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            courses.Add(new Course("Lập trình C#", "CSHARP"));
            courses.Add(new Course("Lập trình Java", "JAVA"));
            courses.Add(new Course("Lập trình C++", "CPP"));
            courses.Add(new Course("Python", "PYTHON"));

            cboCourse.DataSource = courses;
            cboCourse.DisplayMember = "DisplayMember";
            cboCourse.ValueMember = "ValueMember";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string phone = mtxtPhone.Text.Trim();

            string gender = "";
            if (rdoMale.Checked)
                gender = "Nam";
            else if (rdoFemale.Checked)
                gender = "Nữ";

            string hobbies = "";

            if (chkHobby1.Checked)
                hobbies += "Tư duy, ";

            if (chkHobby2.Checked)
                hobbies += "Phân tích, ";

            if (chkHobby3.Checked)
                hobbies += "Sáng tạo, ";

            hobbies = hobbies.TrimEnd(',', ' ');

            if (hobbies == "")
                hobbies = "Không có";

            DateTime birthDate = dtpBirthDate.Value.Date;
            string courseName = cboCourse.Text.Trim();

            if (fullName == "" || phone == "" ||
                gender == "" || courseName == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!",
                    "Thông báo");
                return;
            }

            try
            {
                using (MySqlConnection conn =
                       new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"
                INSERT INTO hocvien
                (hoten, sodienthoai, ngaysinh,
                 gioitinh, sothich, khoahoc)
                VALUES
                (@hoten, @sodienthoai, @ngaysinh,
                 @gioitinh, @sothich, @khoahoc)";

                    using (MySqlCommand cmd =
                           new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@hoten", fullName);
                        cmd.Parameters.AddWithValue("@sodienthoai", phone);
                        cmd.Parameters.AddWithValue("@ngaysinh", birthDate);
                        cmd.Parameters.AddWithValue("@gioitinh", gender);
                        cmd.Parameters.AddWithValue("@sothich", hobbies);
                        cmd.Parameters.AddWithValue("@khoahoc", courseName);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Đăng ký học viên thành công!\n" +
                    "Họ và tên: " + fullName + "\n" +
                    "Số điện thoại: " + phone + "\n" +
                    "Khóa học: " + courseName,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể lưu học viên vào MySQL!\n" +
                    ex.Message,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblHobby2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
