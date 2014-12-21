using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleMeasurementApp
{
    public partial class CircleParameterUI : Form
    {
        Circle aCircle = new Circle();
        public CircleParameterUI()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            aCircle.radious = Convert.ToDouble(radiousAddTextBox.Text);
            diameterLabel.Text = aCircle.GetDiameter().ToString();
            perimeterLabel.Text = aCircle.GetPerimeter().ToString();
            areaLabel.Text = aCircle.GetArea().ToString();
        }
    }
}
