using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Car car = new Car();
        Camel camel = new Camel();
        Horse horse = new Horse();

        private void button1_Click(object sender, EventArgs e)
        {
            IVehicle vehicle = new CamelToCarAdapter(car);
            vehicle.Move();

            vehicle = new HorseToCamelAdapter(camel);
            vehicle.Move();

            vehicle = new CamelToHorseAdapter(horse);
            vehicle.Move();

           /* if(checkBox1.Checked) 
            {
                IVehicle vehicle = new CamelToCarAdapter(car);
                vehicle.Move();
            }
            else if(checkBox2.Checked) 
            {
                vehicle = new HorseToCamelAdapter(camel);
                vehicle.Move();
            }*/
        }
    }
}
