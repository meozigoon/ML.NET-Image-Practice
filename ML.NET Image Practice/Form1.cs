using ML_NET_Image_Practice;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace ML.NET_Image_Practice
{
    public partial class Form1 : Form
    {
        string imagePath = "";

        public Form1()
        {
            InitializeComponent();
            ResultLabel.Text = "Predicted Label:\nCat:\nDog:";
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "�̹��� ���� ����";
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
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

        private void ClassifyButton_Click(object sender, EventArgs e)
        {
            if (imagePath != "")
            {
                List<ImageModel.ModelInput> sampleImages = new()
                {
                    new ImageModel.ModelInput
                    {
                        ImageSource = File.ReadAllBytes(imagePath),
                    }
                };

                sampleImages.ForEach(image =>
                {
                    // Fix: Correctly handle the output of the Predict method
                    ImageModel.ModelOutput predictionResult = ImageModel.Predict(image);
                    ResultLabel.Text = $"Predicted Label: {predictionResult.PredictedLabel}\nCat: {predictionResult.Score[0]}\nDog: {predictionResult.Score[1]}";
                });
            }
        }
    }
}
