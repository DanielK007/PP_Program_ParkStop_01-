using System;
using System.Collections.Generic;
using ParkingStop.Forms;
using ParkingStop.Vehicles_Classes;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingStop.Forms
{
    public partial class AddVehicleBox : Form
    {
        private List<Car> carList = new List<Car>();
        FrontPage frontpage;

        public AddVehicleBox(List<Car> carList)
        {
            InitializeComponent();
            this.carList = carList;
        }

        private void picBxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            frontpage.VehicleIcon();
            Car car = new Car(txtBoxTag.Text,
                               cmbBxVehType.Text,
                               cmbBxVehModel.Text,
                               frontpage.lblDigitalClock.Text,
                               frontpage.TimeControl("Seconds"),
                               frontpage.TimeControl("CostSeconds"));
           carList.Add(car);
           this.Close();
           frontpage.Display();
        }
    }
}
