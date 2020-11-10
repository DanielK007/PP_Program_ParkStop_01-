using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ParkingStop.Vehicles_Classes
{
    public class Vehicle
    {
        public String Tag
        { get; set; }
        public String Type
        { get; set; }
        public String Model
        { get; set; }
        public String TimeIn
        { get; set; }
        public String Duration
        { get; set; }
        public String Payment
        { get; set; }  
        public Icon Icon
        { get; set; }
    }

    public class Icon
    {
        public Icon()
        {
            int a = 10;
            var vehBox = new VehicleControl();
            var infoGet = new FrontPage();
            vehBox.pnlVCMenu.BackColor = Color.DarkRed;
            vehBox.lblTESST.Text = infoGet.txtBoxTag.Text;
            vehBox.Top = 80;
            vehBox.Left = a;
            a = a + 90;
        }
    }
}
