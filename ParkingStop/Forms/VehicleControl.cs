using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingStop
{
    public partial class VehicleControl : UserControl
    {
        private bool isCollapsed;
        public VehicleControl()
        {
            InitializeComponent();
        }

        private void pnlVCMenu_MouseHover(object sender, EventArgs e)
        {
            //VehicleControlTimer.Start();
        }

        private void pnlVCMenu_MouseLeave(object sender, EventArgs e)
        {
            //VehicleControlTimer.Start();
        }

        private void pnlVCMenu_Click(object sender, EventArgs e)
        {
            VehicleControlTimer.Start();
        }
        private void VehicleControlTimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlVCMenu.Height += 5;
                if (pnlVCMenu.Size == pnlVCMenu.MaximumSize)
                {
                    VehicleControlTimer.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                pnlVCMenu.Height -= 5;
                if (pnlVCMenu.Size == pnlVCMenu.MinimumSize)
                {
                    VehicleControlTimer.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnEndPark_Click(object sender, EventArgs e)
        {
            var vehBox = new VehicleControl();
            MessageBox.Show("Button work");
            this.Dispose();
        }
    }
}
