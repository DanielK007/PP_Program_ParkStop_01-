using ParkingStop.Forms;
using ParkingStop.Properties;
using ParkingStop.Vehicles_Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ParkingStop
{
    public partial class FrontPage : Form
    {
        private List<Car> carList;
        
        public FrontPage()
        {
            InitializeComponent();
            carList = new List<Car>();
        }

        //Using the timer, to updtade any method or action placed in there
        private void timerDigClock_Tick(object sender, EventArgs e)
        {
            lblDigitalClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private bool isCollapsed;
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                dGrdViewList.Height -= 10;
                if (dGrdViewList.Height == 100)
                {
                    timerMenu.Stop();
                    isCollapsed = false;
                }        
            }
            else
            {
                dGrdViewList.Height += 10;
                if (dGrdViewList.Height == pnlLeftBar.Height - 300)
                {
                    timerMenu.Stop();
                    isCollapsed = true;
                }
            }
        }

        //======================= User intercations =======================\\
        //    Mouse actions, buttons usage, close window, maximize         \\
        //=================================================================\\

        //======================= Max and Min Screen ======================\\
        //                                                                 \\
        //      There is 3 top buttons, Max/Restore, Min and Close.        \\
        //                                                                 \\
        //=================================================================\\
        private bool maxScrn = false;
        private void pnlMaximize_Click(object sender, EventArgs e)
        {
            if (maxScrn) 
            {
                WindowState = FormWindowState.Normal;
                isCollapsed = false;
                dGrdViewList.Height = 90;
                maxScrn = false;
                pnlMaximize.BackgroundImage = Resources.Btn_Max;
            }
            else
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                isCollapsed = false;
                dGrdViewList.Height = 90;
                maxScrn = true;
                pnlMaximize.BackgroundImage = Resources.Btn_Restore;
            }
        }
        private void pnlExit_Click(object sender, EventArgs e)
        {
            PanelOpen("OExt");
        }
        private void pnlMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //========================= Panel Control =========================\\
        //                                                                 \\
        //      All controls for panels that pop-up.                       \\
        //                                                                 \\
        //=================================================================\\
        private void pnlOpenAdd_Click(object sender, EventArgs e)
        {
            PanelOpen("OAddV");
            //PanelOpen();
        }

        private void FrontPage_MouseDoubleClick(object sender, EventArgs e)
        {
            PanelOpen("OAddV");
            //PanelOpen();
        }
        private void picBxCancel_Click(object sender, EventArgs e)
        {
            PanelOpen("CAddV");
            //PanelOpen();
        }
        
        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            lblListTotal.Text = $"Total: {carList.Count}";
            PanelOpen("CAddV");
            //PanelOpen(false);
            //VehicleIcon();
            Car car = getCar();
            carList.Add(car);
            Display();
            CounTVehicle();


            
            lblListTotal.Text = $"Total in list = {carList.Count}";
        }

        //Remove Vehicle Button
        private void pnlRemove_Click(object sender, EventArgs e)
        {
            if (carList.Count <= 0)
            {
                MessageBox.Show("No Cars Checked In.");
            }
            else
            {
                PanelOpen("OChkOut");
                lblTagCheckOut.Text = dGrdViewList.Rows[dGrdViewList.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtBoxTIOut.Text = dGrdViewList.Rows[dGrdViewList.CurrentCell.RowIndex].Cells[3].Value.ToString();
                txtBoxTOOut.Text = lblDigitalClock.Text;
                txtBoxDurChkOut.Text = TimeControl("CheckOutTime");
                if(dGrdViewList.Rows[dGrdViewList.CurrentCell.RowIndex].Cells[1].Value.ToString() == "Car")
                {
                    txtBoxToPayChkOut.Text = TimeControl("CostSeconds");
                }
                else if (dGrdViewList.Rows[dGrdViewList.CurrentCell.RowIndex].Cells[1].Value.ToString() == "SUV")
                {
                    txtBoxToPayChkOut.Text = TimeControl("CostSecondsSUV");
                }
                else
                {
                    txtBoxToPayChkOut.Text = TimeControl("CostSecondsMotor");
                }
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            string delete = dGrdViewList.SelectedCells[0].Value.ToString();
            carList.RemoveAll(car => car.Tag == delete);
            Display();
            CounTVehicle();
            PanelOpen("CChkOut");
            lblListTotal.Text = $"Total in list = {carList.Count}";
        }

        private void picBxCancelChckOut_Click(object sender, EventArgs e)
        {
            PanelOpen("CChkOut");
        }

        
        private void dGrdViewList_DoubleClick(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        //========================== DropDown Menu ========================\\
        //                                                                 \\
        //      Bellow is the conditionals that populate cars model        \\
        //                                                                 \\
        //=================================================================\\
        private void cmbBxVehType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbBxVehType.Text == "Car")
            {
                cmbBxVehModel.Items.Clear();
                cmbBxVehModel.Items.Add("BMW");
                cmbBxVehModel.Items.Add("Lada");
            }
            else if (cmbBxVehType.Text == "SUV")
            {
                cmbBxVehModel.Items.Clear();
                cmbBxVehModel.Items.Add("Range Rover");
                cmbBxVehModel.Items.Add("Ford");
            }
            else if (cmbBxVehType.Text == "MotorCycle")
            {
                cmbBxVehModel.Items.Clear();
                cmbBxVehModel.Items.Add("BMW");
                cmbBxVehModel.Items.Add("Suzuki");
            }
        }

        //========================= Drag and Move =========================\\
        //                                                                 \\
        //   The code bellow is used to use objects a point to click and   \\
        // drag, so there wont be any need of useing the default windows.  \\
        //                                                                 \\
        //=================================================================\\

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnlTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        //========================= Method Garden =========================\\
        //        ALL METHODS ARE LISTED AND ORGANIZED BELLOW              \\
        //=================================================================\\

        //======================= #M001 Time Control=====================\\
        //  Here the time is translated into String, to be used on other \\
        //  values, so calculation of time and cost is possible          \\
        //  - bool pEnable : True = Shows panel, False = Hides i         \\
        //     Sample: PanelOpen(true) == Shows panel                    \\
        //===============================================================\\
        public String TimeControl(String opt) //#M001
        {
            DateTime intime = DateTime.Parse(lblDigitalClock.Text);
            if (carList.Count > 0)
            {
                intime = DateTime.Parse(dGrdViewList.Rows[dGrdViewList.CurrentCell.RowIndex].Cells[3].Value.ToString());
            }
            DateTime conttime = DateTime.Parse(lblDigitalClock.Text);
            float duration = float.Parse((conttime - intime).TotalSeconds.ToString());
            var span = System.TimeSpan.FromSeconds(duration);
            var hour = ((int)span.TotalHours).ToString();
            var minute = span.Minutes.ToString();
            var seconds = span.Seconds.ToString();

            String response = "";

            if (opt == "Full")
            {
                response = $"Hours: {hour} || Mins: {minute} || Secs: {seconds}";
            }
            if (opt == "Minutes")
            {
                response = $" {minute} Mins";
            }
            if (opt == "Seconds")
            {
                response = $" {seconds} Secs";
            }
            if (opt == "CostSeconds")
            {
                response = $"$ {Convert.ToDouble(duration) * 0.005} ";
            }
            if (opt == "CostSecondsSUV")
            {
                response = $"$ {Convert.ToDouble(duration) * 0.010} ";
            }
            if (opt == "CostSecondsMotor")
            {
                response = $"$ {Convert.ToDouble(duration) * 0.0025} ";
            }
            if (opt == "CheckOutTime")
            {
                if(Convert.ToInt32(seconds) < 60)
                {
                    response = $"  {hour} Hours " +
                               $"  {minute} Minutes " +
                               $"  {seconds} Seconds";
                }
                
            }
            return response;
        }

        //======================= #M002 PanelOpen =======================\\
        //  This method hided and unhide the panel used to add vehicles  \\
        //  - pnlAddVehicle : Name of the object on Design page          \\
        //  - bool pEnable : True = Shows panel, False = Hides i         \\
        //     Sample: PanelOpen(true) == Shows panel                    \\
        //===============================================================\\

        public String PanelOpen(String subMenu) //#M002
        {
            switch (subMenu)
            {
                case "OAddV":
                    pnlAddVehicle.Left = (this.ClientSize.Width - pnlAddVehicle.Width) / 2;
                    pnlAddVehicle.Top = (this.ClientSize.Height - pnlAddVehicle.Height) / 2;
                    pnlAddVehicle.Enabled = true;
                    pnlAddVehicle.Visible = true;
                    break;
                case "CAddV":
                    pnlAddVehicle.Enabled = false;
                    pnlAddVehicle.Visible = false;
                    break;
                case "OExt":
                    if(carList.Count <= 0)
                    {
                        var extBox = new AppExit();
                        extBox.Left = (this.ClientSize.Width - extBox.Width) / 2;
                        extBox.Top = (this.ClientSize.Height - extBox.Height) / 2;
                        this.Controls.Add(extBox);
                        extBox.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("There is still Cars parked.");
                    }
                    break;
                case "CExt":
                    pnlAddVehicle.Enabled = false;
                    pnlAddVehicle.Visible = false;
                    break;
                case "OChkOut":
                    pnlChckOut.Left = (this.ClientSize.Width - pnlChckOut.Width) / 2;
                    pnlChckOut.Top = (this.ClientSize.Height - pnlChckOut.Height) / 2;
                    pnlChckOut.Enabled = true;
                    pnlChckOut.Visible = true;
                    break;
                case "CChkOut":
                    pnlChckOut.Enabled = false;
                    pnlChckOut.Visible = false;
                    break;
            }
            return subMenu;
        }


        //======================= #M002B PanelOpen =======================\\
        //  This method is broken, as the time is not being registered    \\
        //  - pnlAddVehicle : Name of the object on Design page           \\
        //  - bool pEnable : True = Shows panel, False = Hides i          \\
        //     Sample: PanelOpen(true) == Shows panel                     \\
        //================================================================\\
        public bool PanelOpen(bool pEnable) //#M002B
        {
            if (pEnable)
            {
                pnlAddVehicle.Enabled = true;
                pnlAddVehicle.Visible = true;
            }
            else
            {
                pnlAddVehicle.Enabled = false;
                pnlAddVehicle.Visible = false;
            }

            return pEnable;
        }

        //======================= #M003 Vehicle Icon ==========================\\
        //  This method creates the Square icon that shows in the background   \\
        //  Still iunder development, could be removed by the end of the cycle \\
        //=====================================================================\\
        int a = 10;
        public void VehicleIcon() //#M003
        {
            if (cmbBxVehType.Text == "Car")
            {
                var vehBox = new VehicleControl();
                this.Controls.Add(vehBox);
                vehBox.lblTESST.Text = txtBoxTag.Text;
                vehBox.Top = 90;
                vehBox.Left = a;
                a = a + 110;
            }
            else if(cmbBxVehType.Text == "SUV")
            {
                var vehBox = new VehicleControl();
                this.Controls.Add(vehBox);
                vehBox.lblTESST.Text = txtBoxTag.Text;
                vehBox.Top = 90;
                vehBox.Left = a;
                a = a + 110;
            } 
            else
            {
                var vehBox = new VehicleControl();
                this.Controls.Add(vehBox);
                vehBox.Top = 90;
                vehBox.Left = a;
                a = a + 110;
            }
        }

        //========================= #M004 getCar ========================\\
        //   This method create the car class and add information,       \\
        //   returning car with all info.                                \\
        //  - Car: Needs in this order: Tag,Type,Mode,TimeIN,Duration    \\
        //  all strings                                                  \\
        //                                                               \\
        //===============================================================\\
        int counter = 0;
        Car getCar() //#M004
        {
            if (txtBoxTag.Text == "")
            {
                txtBoxTag.Text = $"AAA-000{counter}";
                counter++;
            }
            if(cmbBxVehModel.Text == "")
            {
                cmbBxVehModel.Text = "Car Model";
            }
            if(cmbBxVehType.Text == "")
            {
                cmbBxVehType.Text = "Car";
            }
            Car car = new Car(txtBoxTag.Text,
                              cmbBxVehType.Text, 
                              cmbBxVehModel.Text, 
                              lblDigitalClock.Text, 
                              TimeControl("Seconds"),
                              TimeControl("CostSeconds"));

            cmbBxVehModel.Text = "";
            cmbBxVehType.Text = "";
            txtBoxTag.Clear();
            return car;
        }


        //========================= #M005 Display ========================\\
        //   To organize all information displayed on dataGriview.        \\
        //   dGridViewList: GridView that display the values from carList \\
        //                                                                \\
        //================================================================\\
        int c = 0;
        public void Display() //#M005
        {
            dGrdViewList.DataSource = null;
            dGrdViewList.DataSource = carList;
            this.dGrdViewList.Columns[4].Visible = false;
            this.dGrdViewList.Columns[5].Visible = false;
            this.dGrdViewList.Columns[6].Visible = false;
        }

        //====================== #M007 VehicleCount ======================\\
        //   Count how many types of vehivle exists.                      \\
        //   dGridViewList: GridView that display the values from carList \\
        //                                                                \\
        //================================================================\\
        public void CounTVehicle()
        {
            int carCount = 0;
            int suvCount = 0;
            int bikeCount = 0;
            for (int i = 0; i < carList.Count; i++)
            {
                if (Convert.ToString(carList[i].Type) == "Car")
                {
                    carCount++;
                }
                else if(Convert.ToString(carList[i].Type) == "SUV")
                {
                    suvCount++;
                }
                else if (Convert.ToString(carList[i].Type) == "MotorCycle")
                {
                    bikeCount++;
                }
            }
            if(carCount == 0) { pnlCarCount.Visible = false; }
            else { pnlCarCount.Visible = true; }
            if (suvCount == 0) { pnlSUVCount.Visible = false; }
            else { pnlSUVCount.Visible = true; }
            if (bikeCount == 0) { pnlBikeCount.Visible = false; }
            else { pnlBikeCount.Visible = true; }
            lblTotalCar.Text = carCount.ToString();
            lblTotalSUV.Text = suvCount.ToString();
            lblTotalBike.Text = bikeCount.ToString();
        }

        
    }
}


//Atributes:
//Icons made by <a href="https://www.flaticon.com/authors/freepik" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a>