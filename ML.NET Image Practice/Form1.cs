namespace ML.NET_Image_Practice
{
    public partial class Form1 : Form
    {
        string imagePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "�̹��� ���� ����";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // ���� �̹��� ����
                    if (Image.Image != null)
                    {
                        Image.Image.Dispose();
                    }

                    // ������ ���Ϸ� �̹��� �ε�
                    Image.Image = new Bitmap(openFileDialog.FileName);
                    imagePath = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"�̹����� �ҷ����� ���� ������ �߻��߽��ϴ�.\n\n{ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AnalysisButton_Click(object sender, EventArgs e)
        {
            if (imagePath != "")
            {

            }
        }
    }
}
