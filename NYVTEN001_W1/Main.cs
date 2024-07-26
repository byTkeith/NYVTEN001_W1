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
        }
    }
    

}
