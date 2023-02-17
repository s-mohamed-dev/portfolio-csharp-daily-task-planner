using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DailyTaskPlanner
{
    public partial class Form1 : Form
    {
        // Variables
        bool hasUnsavedModifications = false;

        public Form1()
        {
            InitializeComponent();
            Form1_Resize(null, EventArgs.Empty);

            // Set today's date
            groupBox_TodoToday.Text = DateTime.Today.ToString("dd.MM.yyyy");

            // Load old tasks
            string path = "tasks";
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path, "*.csv");
                // Order the files by date
                files = files.OrderBy(f => DateTime.ParseExact(Path.GetFileNameWithoutExtension(f), "dd.MM.yyyy", CultureInfo.InvariantCulture)).ToArray();

                foreach (string file in files)
                {
                    // Check if it's today's tasks
                    bool isTodaysTask = Path.GetFileNameWithoutExtension(file) == DateTime.Today.ToString("dd.MM.yyyy");

                    GroupBox groupBox_TodoOld = new GroupBox();
                    CheckedListBox checkedListBox_TodoOld = new CheckedListBox();
                    checkedListBox_TodoOld.Dock = DockStyle.Fill;
                    checkedListBox_TodoOld.HorizontalScrollbar = true;
                    checkedListBox_TodoOld.Enabled = false;

                    using (StreamReader sr = new StreamReader(file))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] data = line.Split(';');
                            checkedListBox_TodoOld.Items.Add(data[1], Convert.ToBoolean(data[0]));

                            // Load today's tasks (if from current date)
                            if (isTodaysTask) checkedListBox_TodoToday.Items.Add(data[1], Convert.ToBoolean(data[0]));
                        }
                    }

                    groupBox_TodoOld.Padding = new Padding(16);
                    groupBox_TodoOld.Dock = DockStyle.Top;
                    groupBox_TodoOld.Text = Path.GetFileNameWithoutExtension(file);
                    // Calculate the minimum size based on the number of tasks
                    groupBox_TodoOld.MinimumSize = new Size(1, Math.Max((int)Math.Round(23.333f * 6), (int)Math.Round(23.333f * checkedListBox_TodoOld.Items.Count)));
                    groupBox_TodoOld.Controls.Add(checkedListBox_TodoOld);

                    // Add todo (if not from current date)
                    if (!isTodaysTask) tabPage_TodoOld.Controls.Add(groupBox_TodoOld);
                }
            }
        }

        // Shows an input box for the user to enter a text string
        private string ShowInputBox(string title= "Enter your text", string defaultText="")
        {
            using (var form = new Form())
            {
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                form.Width = 480;
                form.Text = title;

                int margin = 5;

                var textBox = new TextBox()
                {
                    Left = margin,
                    Top = margin,
                    Width = form.Width - (margin * 5),
                    Text = defaultText,
                };

                var buttonOk = new Button()
                {
                    Text = "OK",
                    Left = form.Width - (margin * 4) - 75,
                    Width = 75,
                    Top = textBox.Height + (margin * 2),
                    DialogResult = DialogResult.OK,
                };

                form.Height = (textBox.Height + buttonOk.Height + margin) * 2;

                form.Controls.Add(textBox);
                form.Controls.Add(buttonOk);
                form.AcceptButton = buttonOk;

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Returns the entered text
                    return textBox.Text;
                }
            }

            // Returns the default text if the dialog is cancelled
            return defaultText;
        }

        // Returns the default text if the dialog is cancelled
        private void Form1_Resize(object sender, EventArgs e)
        {
            groupBox_TodoToday.Height = ClientSize.Height - groupBox_Action.Height - 48;
        }

        // Returns the default text if the dialog is cancelled
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hasUnsavedModifications)
            {
                DialogResult result = MessageBox.Show("Do you really want to quit without saving the modifications?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        // Adds a new item to the 'Todo Today' list
        private void button_ActionAdd_Click(object sender, EventArgs e)
        {
            int index = checkedListBox_TodoToday.SelectedIndex;
            if (index == -1)
            {
                checkedListBox_TodoToday.Items.Add(ShowInputBox("Enter the new text for the item to add", ""));
                hasUnsavedModifications = true;
            }
            else
                checkedListBox_TodoToday.Items.Insert(index + 1, ShowInputBox("Enter the new text for the item to add", ""));
        }

        // Deletes the selected item from the 'Todo Today' list
        private void button_ActionDelete_Click(object sender, EventArgs e)
        {
            if (checkedListBox_TodoToday.SelectedIndex != -1)
            {
                checkedListBox_TodoToday.Items.RemoveAt(checkedListBox_TodoToday.SelectedIndex);
                hasUnsavedModifications= true;
            }
            else
                MessageBox.Show("Select an item before attempting to delete it.");
        }

        // Modify the selected item from the 'Todo Today' list
        private void button_ActionModify_Click(object sender, EventArgs e)
        {
            if (checkedListBox_TodoToday.SelectedIndex != -1)
            {
                checkedListBox_TodoToday.Items[checkedListBox_TodoToday.SelectedIndex] = ShowInputBox("Enter the new text for the selected item.", checkedListBox_TodoToday.SelectedItem.ToString());
                hasUnsavedModifications = true;
            }
            else
                MessageBox.Show("You must select an item before making modifications to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Save the 'Todo Today' list
        private void button_ActionSave_Click(object sender, EventArgs e)
        {
            string path = "tasks";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (StreamWriter sw = new StreamWriter(Path.Combine(path, groupBox_TodoToday.Text + ".csv")))
            {
                for (int i = 0; i < checkedListBox_TodoToday.Items.Count; i++)
                    sw.WriteLine(checkedListBox_TodoToday.GetItemChecked(i) + ";" + checkedListBox_TodoToday.Items[i].ToString());
            }

            hasUnsavedModifications = false;
        }

        // Check event triggered for an item in the 'Todo Today' list.
        private void checkedListBox_TodoToday_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            hasUnsavedModifications = true;
        }
    }
}
