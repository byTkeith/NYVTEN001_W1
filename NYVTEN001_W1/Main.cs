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
        }
    }
    

}
