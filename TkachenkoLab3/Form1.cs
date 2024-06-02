using Lab4.classes;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        const string FilePath = "data/ChimicalElement.XML";
        ElementsList elementalList = new ElementsList();

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadElementsFromXml();
            PopulateDataGridView(elementalList);
        }

        private void addNewRowButton_Click(object sender, EventArgs e)
        {
            this.ElementdataGridView.Rows.Add();
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {

        }

        private void SetupLayout()
        {
            this.Size = new Size(600, 500);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void SetupDataGridView()
        {
            this.Controls.Add(ElementdataGridView);

            ElementdataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            ElementdataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ElementdataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(ElementdataGridView.Font, FontStyle.Bold);

            ElementdataGridView.Name = "dataGridView1";
            ElementdataGridView.Location = new Point(8, 8);
            ElementdataGridView.Size = new Size(500, 250);
            ElementdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            ElementdataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ElementdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            ElementdataGridView.GridColor = Color.Black;
            ElementdataGridView.RowHeadersVisible = false;

            ElementdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ElementdataGridView.MultiSelect = false;
            ElementdataGridView.Dock = DockStyle.Fill;
        }

        private void PopulateDataGridView(ElementsList elementalList)
        {
            ElementdataGridView.DataSource = elementalList.GetElements();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text;

            int columnIndex = comboBox1.SelectedIndex;
            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.SelectedIndex = 0;
                MessageBox.Show("Вы не указали ячейку по которой будет происходить поиск.\nЯчейка выбрана автоматически(Name)");
                return;
            }

            for (int i = 0; i < ElementdataGridView.RowCount; i++)
            {
                ElementdataGridView.Rows[i].Selected = false;
            }

            for (int i = 0; i < ElementdataGridView.RowCount; i++)
            {
                if (ElementdataGridView.Rows[i].Cells[columnIndex].Value != null)
                {
                    if (ElementdataGridView.Rows[i].Cells[columnIndex].Value.ToString().Contains(searchQuery))
                    {
                        ElementdataGridView.Rows[i].Selected = true;
                    }
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length > 0 && LatinNameTextBox.Text.Length > 0 && SybmolTextBox.Text.Length > 0 && AtomicMassTextBox.Text.Length > 0)
            {
                Element element = new Element(NameTextBox.Text, LatinNameTextBox.Text, SybmolTextBox.Text, float.Parse(AtomicMassTextBox.Text));
                AddElementToXml(element);
                elementalList.AddElement(element);
                PopulateDataGridView(elementalList);
                ElementdataGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Нужно заполнить все ячейки");
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadElementsFromXml();
            PopulateDataGridView(elementalList);
            ElementdataGridView.Refresh();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void LoadElementsFromXml()
        {
            var filePath = FilePath;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            foreach (XmlNode elementNode in xmlDoc.SelectNodes("//element"))
            {
                Element element = new Element(
                    elementNode["name"].InnerText,
                    elementNode["latin_name"].InnerText,
                    elementNode["symbol"].InnerText,
                    float.Parse(elementNode["atomic_mass"].InnerText, CultureInfo.InvariantCulture)
                );

                elementalList.AddElement(element);
            }
        }

        private void AddElementToXml(Element element)
        {
            XDocument xmlDoc = XDocument.Load(FilePath);
            XElement rootElement = xmlDoc.Root;
            XElement newElement = new XElement("element",
                new XElement("name", element.Name),
                new XElement("latin_name", element.LatinName),
                new XElement("symbol", element.Symbol),
                new XElement("atomic_mass", element.AtomicMass.ToString())
            );
            rootElement.Add(newElement);
            xmlDoc.Save(FilePath);
            elementalList.AddElement(element);
            elementalList = new ElementsList(); // Создаем новый объект ElementsList
            LoadElementsFromXml(); // Загружаем элементы из XML
            PopulateDataGridView(elementalList); // Обновляем DataGridView
        }

        private void deleteRowButton_Click_1(object sender, EventArgs e)
        {
            if (this.ElementdataGridView.SelectedRows.Count > 0 &&
                this.ElementdataGridView.SelectedRows[0].Index != this.ElementdataGridView.Rows.Count )
            {
                int selectedIndex = this.ElementdataGridView.SelectedRows[0].Index;
                Element element = new Element(
                    this.ElementdataGridView.Rows[selectedIndex].Cells[0].Value.ToString(),
                    this.ElementdataGridView.Rows[selectedIndex].Cells[1].Value.ToString(),
                    this.ElementdataGridView.Rows[selectedIndex].Cells[2].Value.ToString(),
                    float.Parse(this.ElementdataGridView.Rows[selectedIndex].Cells[3].Value.ToString())
                );

                // Удаление из XML
                XDocument xmlDoc = XDocument.Load(FilePath);
                XElement rootElement = xmlDoc.Root;
                XElement elementToDelete = rootElement.Elements("element")
                    .FirstOrDefault(el =>
                        el.Element("name").Value == element.Name &&
                        el.Element("latin_name").Value == element.LatinName &&
                        el.Element("symbol").Value == element.Symbol
                    );
                elementToDelete?.Remove();
                xmlDoc.Save(FilePath);

                // Удаление из списка элементов
                elementalList.RemoveElement(element);

                // Обновление DataGridView
                elementalList = new ElementsList(); // Создаем новый объект ElementsList
                LoadElementsFromXml(); // Загружаем элементы из XML
                PopulateDataGridView(elementalList); // Обновляем DataGridView
            }
        }

        private void ShowTableButton_Click(object sender, EventArgs e)
        {

        }
    }
}