using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYVTEN001_W1
{
    public class MainForm : Form
    {
        private July july;
        private TextBox txtName, txtAge, txtHeight, txtTime1, txtTime2, txtTime3;
        private TextBox txtOutput;
        private Button btnAdd, btnPredict;

        public MainForm()
        {
            july= new July();
            InitializeComponents();

        }

        private void InitializeComponents()
        {
            this.Text = "Durban July Horse Meet";
            this.Size = new System.Drawing.Size(400, 400);//added frame size

            txtName = CreateTextBox("Name", 10, 10);
            txtAge = CreateTextBox("Age", 10, 40);
            txtHeight= CreateTextBox("Height", 10, 70);
            txtTime1= CreateTextBox("Time1", 10, 100);
            txtTime2= CreateTextBox("Time2", 10, 130);
            txtTime3= CreateTextBox("Time3", 10, 160);

            txtOutput = new TextBox { Multiline = true, Width = 350, Height = 150, Top = 200, Left = 10 };
            this.Controls.Add(txtOutput);

            btnAdd = new Button { Text = "Add", Top = 360, Left = 10 };
            btnAdd.Click += Btn_Click;
            this.Controls.Add(btnAdd);

            btnPredict = new Button { Text = "Predict next winner", Top = 360, Left = 100 };
            btnPredict.Click += btnPredict_Click;
            this.Controls.Add( btnPredict );

        }

        private TextBox CreateTextBox(string placeholder, int left, int top)
        {
            var textBox = new TextBox { Width = 100, left = left, Top = top, placeholder = placeholder };
            this.Controls.Add(textBox);
            return textBox;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name=txtName.Text;
            int age= int.Parse(txtAge.Text);
            int height= int.Parse(txtHeight.Text);
            double[] times= new double[] {
            double.Parse(txtTime1.Text),
            double.Parse(txtTime2.Text),
            double.Parse(txtTime3.Text)
            };

            Horse horse= new Horse(name, age, height, times);
            july.AddHorse( horse );
        }
    }
    

}
