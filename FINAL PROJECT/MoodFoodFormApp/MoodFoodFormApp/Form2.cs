using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MoodFoodFormApp.Classes;

namespace MoodFoodFormApp
{
    public partial class Form2 : Form
    {
        public static string mood;
        public static string time;
        public static string restrictions;
        public static string analyses;

        public Form2()
        {
            InitializeComponent();
            checkBoxGluten.CheckedChanged += CheckBox_CheckedChanged;
            checkBoxLactose.CheckedChanged += CheckBox_CheckedChanged;
            checkBoxVegetarian.CheckedChanged += CheckBox_CheckedChanged;
            checkBoxVegan.CheckedChanged += CheckBox_CheckedChanged;
            checkBoxShellfish.CheckedChanged += CheckBox_CheckedChanged;
            checkBoxNut.CheckedChanged += CheckBox_CheckedChanged;
            comboBoxMood.Text = "Select Mood";
            comboBoxTime.Text = "Select Time";
            comboBoxMood.ForeColor = SystemColors.GrayText;
            comboBoxTime.ForeColor = SystemColors.GrayText;
        }
        
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            foreach (Control control in Controls)
            {
                if (control is CheckBox && control != checkBox)
                {
                    control.Enabled = !checkBox.Checked;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (comboBoxMood.Text == "" || comboBoxTime.Text == "")
            {
                MessageBox.Show("The MOOD and the TIME OF FOOD have to be selected");
                return;
            }
            else
            {
                UserInfo ui = new UserInfo();
                ui.Mood = comboBoxMood.Text;
                ui.Time = comboBoxTime.Text;

                if (checkBoxGluten.Checked)
                {
                    ui.Restrictions += checkBoxGluten.Text;
                }
                if (checkBoxLactose.Checked)
                {
                    ui.Restrictions += checkBoxLactose.Text;
                }
                if (checkBoxVegetarian.Checked)
                {
                    ui.Restrictions += checkBoxVegetarian.Text;
                }
                if (checkBoxVegan.Checked)
                {
                    ui.Restrictions += checkBoxVegan.Text;
                }
                if (checkBoxShellfish.Checked)
                {
                    ui.Restrictions += checkBoxShellfish.Text;
                }
                if (checkBoxNut.Checked)
                {
                    ui.Restrictions += checkBoxNut.Text;
                }

                mood = ui.Mood;
                time = ui.Time;
                restrictions = ui.Restrictions;

                Form3 form3 = new Form3(mood, restrictions, time, analyses);
                form3.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
