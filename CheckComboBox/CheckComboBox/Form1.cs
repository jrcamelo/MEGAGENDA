using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckBoxCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // add three check box items to the combo box and set their checked states to true
            checkComboBox1.Items.Add(new CheckComboBox.CheckComboBoxItem("One", true));
            checkComboBox1.Items.Add(new CheckComboBox.CheckComboBoxItem("Two", true));
            checkComboBox1.Items.Add(new CheckComboBox.CheckComboBoxItem("Three", true));

            


            // disable the checkboxes so the user can't edit them
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;

            // wire up the check state changed event
            this.checkComboBox1.CheckStateChanged += new System.EventHandler(this.checkComboBox1_CheckStateChanged);

        }

        // this message handler gets called when the user checks/unchecks an item the combo box
        private void checkComboBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (sender is CheckComboBox.CheckComboBoxItem)
            {
                CheckComboBox.CheckComboBoxItem item = (CheckComboBox.CheckComboBoxItem)sender;
                switch (item.Text)
                {
                    case "One":
                        checkBox1.Checked = item.CheckState;
                        break;
                    case "Two":
                        checkBox2.Checked = item.CheckState;
                        break;
                    case "Three":
                        checkBox3.Checked = item.CheckState;
                        break;
                }
            }
        }
    }
}