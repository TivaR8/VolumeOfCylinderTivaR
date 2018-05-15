using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 14-05-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Volume of a Cylinder
 * This program 
*/

namespace VolumeOfCylinderTivaR
{
    public partial class frmVolumeOfCylinder : Form
    {
        public frmVolumeOfCylinder()
        {
            InitializeComponent();

        }

        // Function: CalculateVolume
        // Input: double radius, double height
        // Output: double volume
        // Description:
        private double CalculateVolume(double radius, double height)
        {
            // Define const
            const double PI = 3.14;

            double volume;

            volume = (PI * Math.Pow(radius, 2) * height);

            return volume;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declare local variables
            double radius, height;

            // Get the values from text boxes
            radius = Convert.ToDouble(txtRadius.Text);
            height = Convert.ToDouble(txtHeight.Text);

            // Call function

        }
    }
}
