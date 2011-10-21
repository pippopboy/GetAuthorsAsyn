using System;
using System.Windows.Forms;
using GetAuthors.AuthorsService;
using System.Threading;
namespace GetAuthors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            AuthorsClient AuthorClient = new AuthorsClient();
            MessageBox.Show("Tên Thành Viên Nhóm : " + AuthorClient.Getauthors().GroupName + "\nTên Project: " +
                            AuthorClient.Getauthors().ProjectName
                            +"\nChu ý progressbar, sau khi click ok progressbar sẽ chạy!");
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 7;
            progressBar1.Step = 1;
            for (int i = 0; i < 7; i++)
            {
                Thread.Sleep(7000);
                progressBar1.PerformStep();
            }
            label1.Visible = true;
            label1.Text = "Đồng bộ: progressbar chay sau khi hoan tất messageshow";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            AuthorsClient authorsClient = new AuthorsClient();
            authorsClient.GetauthorsCompleted+=new EventHandler<GetauthorsCompletedEventArgs>(authorsClient_GetauthorsCompleted);
            authorsClient.GetauthorsAsync();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;
            progressBar1.Step = 1;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                progressBar1.PerformStep();
            }
            label1.Visible = true;
            label1.Text = "Bất Đồng bô: progressbar chạy cùng lúc khi computer đang lấy thông tin author";
        }

        private void authorsClient_GetauthorsCompleted(object sender, GetauthorsCompletedEventArgs e)
        {
            MessageBox.Show("Tên Thành Viên Nhóm : " + e.Result.GroupName + "\nTên Project: " +
                           e.Result.ProjectName + "\nProgressbar sẽ chạy trong khi chờ xử lý!");
        }
    }
}
