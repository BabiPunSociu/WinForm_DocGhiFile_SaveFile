using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Bai17_DocGhiFile_SaveFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string MoFile()
        {
            OpenFileDialog odlg = new OpenFileDialog();
            if (odlg.ShowDialog() == DialogResult.OK)
                return odlg.FileName;
            return null;
        }
        private void btnDocFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chỉ đọc file text như .docx, .doc, .txt, ...");
            string nameFile = MoFile();
            if (nameFile == null)
                return;

            /* Mở luồng đọc file */
            StreamReader reader = new StreamReader(nameFile /* Đường dẫn + tên file */);

            /*
             * Đọc từng dòng (có thể dùng thêm loop không xác định): Noidung = Tenluong.ReadLine()
             * Đọc từ đầu đến cuối vào 1 biến: Noidung = Tenluong.ReadToEnd()
            */

            string DongDau = reader.ReadLine();
            txtDocFile.Clear();
            txtDocFile.Text = DongDau + "     ";

            while (true)
            {
                string TextLine = reader.ReadLine();
                if (TextLine == null)
                    break;
                txtDocFile.Text += TextLine;
            }

            // Đóng luồng
            reader.Close();
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            // Không kiểm tra: txtGhiFile.Text = "";

            MessageBox.Show("Chỉ ghi file text như .docx, .doc, .txt, ...");
            /* Lấy đường dẫn file cần ghi dữ liệu */
            string nameFile = MoFile();
            if (nameFile == null)
                return;

            /* Quá trình ghi dữ liệu vào file */
            // Mở luồng ghi file
            StreamWriter writer = new StreamWriter(nameFile /* Đường dẫn + Tên file */);

            /*
             * Ghi từng dòng dữ liệu vào file:  Tenluong.WriteLine(“Noidung”)
             * Ghi tất cả dữ liệu vào file:     Tenluong.Write(“Noidung”)
            */

            writer.Write(txtGhiFile.Text);

            // Đóng luồng
            writer.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog odlg = new SaveFileDialog(); // Hộp thoại Save (có thể tạo bằng kéo thả)
            odlg.Title = "Lưu file";
            odlg.Filter = "Word|*.docx|Text|*.txt|Icons|*.ico|Ảnh|*.jpg|AllFiles|*.*";
            odlg.FilterIndex = 5;   // Chỉ ra bộ lọc tập tin mặc định

            /*
               Cho phép tự động thêm "phần mở rộng" hiện hành vào tên file
               khi người dùng không chỉ rõ phần mở rộng
            */
            odlg.AddExtension = true;

            /* 
               Cung cấp phần mở rộng mặc định cho tên tệp nếu người dùng không
               chỉ rõ phần mở rộng của tên tệp
            */
            odlg.DefaultExt = ".txt";

            odlg.InitialDirectory = "Desktop";  // Xác định thƣ mục mặc định
            odlg.FileName = "";

            if(string.IsNullOrEmpty(txtGhiFile.Text.Trim()))
            {
                txtGhiFile.Clear();
                txtGhiFile.Focus();
                MessageBox.Show("Cần nhập dữ liệu");
                return;
            }    

            if (odlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(odlg.FileName);
                try
                {
                    file.Write(txtGhiFile.Text);
                    MessageBox.Show("Thành công");
                }
                catch
                {
                    MessageBox.Show("Lỗi ghi file");
                }
                file.Close();
            }
            else
                MessageBox.Show("you clicked Cancel");
        }
    }
}
