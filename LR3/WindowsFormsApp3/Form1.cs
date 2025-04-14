using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyOrderApp
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> drugGroups;

        public Form1()
        {
            InitializeComponent();
            InitializeDrugGroups();
            comboBoxGroups.SelectedIndexChanged += ComboBoxGroups_SelectedIndexChanged;
            buttonOrder.Click += ButtonOrder_Click;
        }

        private void InitializeDrugGroups()
        {
            // Определение групп и препаратов
            drugGroups = new Dictionary<string, List<string>>
            {
                { "Анальгетики", new List<string> { "Парацетамол", "Анальгин", "Ибупрофен" } },
                { "Антибиотики", new List<string> { "Амоксициллин", "Цефтриаксон", "Азитромицин" } },
                { "Витамины", new List<string> { "Витамин C", "Витамин D", "Комплекс B" } }
            };

            comboBoxGroups.Items.AddRange(drugGroups.Keys.ToArray());
        }

        private void ComboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDrugs.Controls.Clear();
            string selectedGroup = comboBoxGroups.SelectedItem.ToString();
            List<string> drugs = drugGroups[selectedGroup];

            int y = 10;
            foreach (var drug in drugs)
            {
                CheckBox checkBox = new CheckBox
                {
                    Text = drug,
                    Location = new System.Drawing.Point(10, y),
                    AutoSize = true
                };
                NumericUpDown numeric = new NumericUpDown
                {
                    Location = new System.Drawing.Point(150, y - 2),
                    Width = 50,
                    Minimum = 1,
                    Maximum = 100,
                    Enabled = false
                };

                checkBox.CheckedChanged += (s, args) =>
                {
                    numeric.Enabled = checkBox.Checked;
                };

                panelDrugs.Controls.Add(checkBox);
                panelDrugs.Controls.Add(numeric);
                y += 30;
            }
        }

        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            string selectedGroup = comboBoxGroups.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedGroup))
            {
                MessageBox.Show("Выберите номенклатурную группу.");
                return;
            }

            var result = $"Группа: {selectedGroup}\r\n";
            foreach (Control control in panelDrugs.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    var numeric = panelDrugs.Controls.OfType<NumericUpDown>()
                        .FirstOrDefault(n => n.Location.Y == checkBox.Location.Y - 2);
                    result += $"- {checkBox.Text}: {numeric?.Value} шт.\r\n";
                }
            }

            textBoxResult.Text = result;
            Console.WriteLine("H");
        }
    }
}