using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace DZ_NA_22._03
{
    public partial class Form1 : Form
    {
        private class ImageEntry
        {
            public string Path { get; set; }  // Путь к изображению
            public string Title { get; set; } // Заголовок изображения

            public override string ToString() => $"{Path},{Title}";
        }
        private List<ImageEntry> imageEntries = new List<ImageEntry>();
        private void LoadImagesFromFile()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Text files (*.txt)|*.txt"; // Фильтр для текстовых файлов
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(dialog.FileName); // Читаем строки в массив
                    imageEntries.Clear(); // Очищаем список перед добавлением
                    listBoxImages.Items.Clear(); // Очищаем ListBox

                    foreach (var line in lines)
                    {
                        var parts = line.Split(','); // Разделяем строку по запятой
                        if (parts.Length == 2)
                        {
                            imageEntries.Add(new ImageEntry { Path = parts[0], Title = parts[1] }); // Добавляем запись
                            listBoxImages.Items.Add(parts[0]); // Добавляем путь к изображению в ListBox
                        }
                    }
                }
            }
        }
        private void SaveImagesToFile()
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Text files (*.txt)|*.txt"; // Фильтр для текстовых файлов
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    List<string> lines = new List<string>(); // Список для подготовки записи
                    foreach (var entry in imageEntries) // Проходим по каждому элементу
                    {
                        lines.Add(entry.ToString()); // Добавляем каждую запись в формате "путь,заголовок"
                    }
                    File.WriteAllLines(dialog.FileName, lines); // Сохраняем данные в файл
                }
            }
        }
        private void DisplaySelectedImage()
        {
            if (listBoxImages.SelectedIndex >= 0) // Проверяем, что выбран элемент
            {
                var selectedEntry = imageEntries[listBoxImages.SelectedIndex]; // Получаем выбранный элемент
                pictureBox.Image = Image.FromFile(selectedEntry.Path); // Загружаем изображение в PictureBox
                textBoxTitle.Text = selectedEntry.Title; // Отображаем заголовок в TextBox
            }
        }

        public Form1()
        {
            InitializeComponent();
            buttonLoadImages.Click += buttonLoadImages_Click; // Подписка на событие загрузки
            buttonSaveImages.Click += buttonSaveImages_Click; // Подписка на событие сохранения
            listBoxImages.SelectedIndexChanged += listBoxImages_SelectedIndexChanged; // Подписка на изменение выбора

        }
        private void buttonLoadImages_Click(object sender, EventArgs e)
        {
            LoadImagesFromFile(); // Загружаем изображения
        }

        private void buttonSaveImages_Click(object sender, EventArgs e)
        {
            SaveImagesToFile(); // Сохраняем изображения
        }

        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedImage(); // Отображаем выбранное изображение
        }

        private void btnLoadImages_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
