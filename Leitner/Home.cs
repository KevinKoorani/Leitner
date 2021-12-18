using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Engine.DAL.Interface;
using Engine.DAL.Model;

namespace Leitner
{
    public partial class Home : Form
    {
        private readonly IDataService _service;
        private List<Data> _dataList;

        public Home(IDataService service)
        {
            _service = service;
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            EnglishDate.Text = date.ToString("yyyy/MM/dd");
            var pc = new PersianCalendar();
            PersianDate.Text = $@"{pc.GetYear(date)}/{pc.GetMonth(date)}/{pc.GetDayOfMonth(date)}";
        }

        private void Boxes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            GetAllInSectionListBoxItems();
        }

        private void AllInSectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = _dataList.Single(i => i.Key == allInSectionListBox.SelectedItem);
            keyTextBox.Text = item.Key;
            uKeyTextBox.Text = item.Key;
            dKeyTextBox.Text = item.Key;
            descTextBox.Text = item.Description;
            uDescTextBox.Text = item.Description;
            valueTextBox.Text = string.Empty;
        }

        private void ShowValueButton_Click(object sender, EventArgs e)
        {
            var value = _dataList.Single(i => i.Key == allInSectionListBox.SelectedItem).Value;
            valueTextBox.Text = value;
            uValueTextBox.Text = value;
        }

        private void UpdateBoxesButton_Click(object sender, EventArgs e)
        {
            _service.UpdateBoxes();
            ShowSuccessfullMessage();
        }

        private void CurrectAnswerButton_Click(object sender, EventArgs e)
        {
            var data = _dataList.Single(i => i.Key == allInSectionListBox.SelectedItem);
            if (data.Section < (int) Math.Pow(2, data.Box - 1))
                data.Section += 1;
            else
            {
                data.Section = 1;
                data.Box += 1;
            }

            _service.Update(data);
            ShowSuccessfullMessage();
        }

        private void WrongAnswerButton_Click(object sender, EventArgs e)
        {
            var data = _dataList.Single(i => i.Key == allInSectionListBox.SelectedItem);
            data.Section = 1;
            data.Box = 1;
            _service.Update(data);
            ShowSuccessfullMessage();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            _service.Create(new Data
            {
                Key = cKeyTextBox.Text,
                Value = cValueTextBox.Text,
                Description = cDescTextBox.Text,
                Box = 1,
                Section = 1,
                CreatedDate = DateTime.Now,
                Date = DateTime.Now
            });
            ShowSuccessfullMessage();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var data = _dataList.Single(i => i.Key == allInSectionListBox.SelectedItem);
            data.Box = (int) uBoxNumericUpDown.Value;
            data.Section = (int) uSectionNumericUpDown.Value;
            data.Key = uKeyTextBox.Text;
            data.Value = uValueTextBox.Text;
            data.Description = uDescTextBox.Text;
            _service.Update(data);
            ShowSuccessfullMessage();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var data = _dataList.SingleOrDefault(i => i.Key == dKeyTextBox.Text &&
                                             i.Box == (int) dBoxNumericUpDown.Value &&
                                             i.Section == (int) dSectionNumericUpDown.Value);
            _service.Delete(data);
            ShowSuccessfullMessage();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ShowSuccessfullMessage()
        {
            MessageBox.Show("Successfully Done!", "Result", MessageBoxButtons.OK);
            GetAllInSectionListBoxItems();
        }

        private void GetAllInSectionListBoxItems()
        {
            allInSectionListBox.Items.Clear();
            var node = Boxes.SelectedNode;
            if (node.Name.Contains("Box"))
                return;
            var parent = node.Parent;
            var nodeIndex = Convert.ToInt32(node.Text.Split(' ')[1]);
            var parentIndex = Convert.ToInt32(parent.Text.Split(' ')[1]);
            _dataList = _service.GetByFullSection(parentIndex, nodeIndex);
            foreach (var item in _dataList)
                allInSectionListBox.Items.Add(item.Key);
        }
    }
}