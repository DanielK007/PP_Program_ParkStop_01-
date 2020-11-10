using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingStop
{
    class DumpTheCode
    {
        //Nothing to see here, just code back up.
    }
}

/*
 namespace ParkingStop
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
        }

        private void FrontPage_Load(object sender, EventArgs e)
        {
            //Starting the digital clock simple way
            //timerDigClock.Start();

            //Bug safe way
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                lblDigitalClock.Text = DateTime.Now.ToString("HH:mm:ss");
            }));
        }

        private void timerDigClock_Tick(object sender, EventArgs e)
        {
            //Digital clock code
            lblDigitalClock.Text = DateTime.Now.ToString("HH:mm:ss");

            //Working with colors and tick
            if(pnlTick.BackColor == Color.Navy)
            {
                pnlTick.BackColor = Color.Blue;
            }
            else
            {
                pnlTick.BackColor = Color.Navy;
            }

            //How to turn off the timer
            //timerDigClock.Enabled = true;

            //How to increase Interval or decrease
            //timerDigClock.Interval = timerDigClock.Interval - 10;

            //Printing timer interval
            lblInterval.Text = Convert.ToString(timerDigClock.Interval);

            DateTime intime = DateTime.Parse(lblTimeReg.Text);
            DateTime outtime = DateTime.Parse(lblTimeRegEnd.Text);
            DateTime conttime = DateTime.Parse(lblDigitalClock.Text);
            float duration = float.Parse((conttime - intime).TotalMinutes.ToString());
            var span = System.TimeSpan.FromMinutes(duration);
            var hour = ((int)span.TotalHours).ToString();
            var minute = span.Minutes.ToString();
            var seconds = span.Seconds.ToString();
            lblResult.Text = $"Duration\n Minutes: {minute} mins \nSeconds: {seconds} secs";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblTimeReg.Text = lblDigitalClock.Text;
        }

        private void btnAddEnd_Click(object sender, EventArgs e)
        {
            lblTimeRegEnd.Text = lblDigitalClock.Text;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            DateTime intime = DateTime.Parse(lblTimeReg.Text);
            DateTime outtime = DateTime.Parse(lblTimeRegEnd.Text);
            DateTime conttime = DateTime.Parse(lblDigitalClock.Text);
            float duration = float.Parse((conttime - intime).TotalMinutes.ToString());
            var span = System.TimeSpan.FromMinutes(duration);
            var hour = ((int)span.TotalHours).ToString();
            var minute = span.Minutes.ToString();
            var seconds = span.Seconds.ToString();
            lblResult.Text = $"Duration\n Minutes: {minute} mins \nSeconds: {seconds} secs";

            lblCost.Text = $"$ {Convert.ToDouble(seconds) * 0.15} ";
        }

        private void picBxExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quit?", "ParkStop", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            DateTime intime = DateTime.Parse(lblTimeReg.Text);
            DateTime outtime = DateTime.Parse(lblTimeRegEnd.Text);
            DateTime conttime = DateTime.Parse(lblDigitalClock.Text);
            float duration = float.Parse((conttime - intime).TotalMinutes.ToString());
            var span = System.TimeSpan.FromMinutes(duration);
            var hour = ((int)span.TotalHours).ToString();
            var minute = span.Minutes.ToString();
            var seconds = span.Seconds.ToString();

            //Feeding the GridInformation
            int n = dGrdViewList.Rows.Add();
            //Tag
            dGrdViewList.Rows[n].Cells[0].Value = txtBoxTag.Text;
            //Model
            dGrdViewList.Rows[n].Cells[1].Value = cmbBxCarType.Text;
            //Type
            dGrdViewList.Rows[n].Cells[2].Value = "Car";
            //Time In
            dGrdViewList.Rows[n].Cells[3].Value = lblDigitalClock.Text;
            //Duration
            dGrdViewList.Rows[n].Cells[4].Value = lblResult.Text;
        }
    }
}


//Box Creator
            var vehBox = new Panel();
            this.Controls.Add(vehBox);
            vehBox.BackColor = Color.Navy;
            vehBox.Width = 80;
            vehBox.Height = 80;
            vehBox.Top = 80;
            vehBox.Left = a;
            a = a + 90;

            pnlAddVehicle.Enabled = false;
            pnlAddVehicle.Visible = false;


//Time controls

    //How to turn off the timer
    //timerDigClock.Enabled = true;

    //How to increase Interval or decrease
    //timerDigClock.Interval = timerDigClock.Interval - 10;

       **Add on the main page load out vvvv
    //Starting the digital clock simple way
    //timerDigClock.Start();

            

public void VehicleInfo()
        {
            //Feeding the GridInformation
            int n = dGrdViewList.Rows.Add();

            //Tag (Vehicle Tag)
            if (txtBoxTag.Text != "")
            {
                dGrdViewList.Rows[n].Cells[0].Value = txtBoxTag.Text;
            }
            else
            {
                dGrdViewList.Rows[n].Cells[0].Value = $"AAA-000{counter}";
                counter++;
            }

            //Type (False = Car , True = Motorcyle)
            if (chkBxIsBike.Checked == false)
            {
                dGrdViewList.Rows[n].Cells[1].Value = "Car";
            }
            else
            {
                dGrdViewList.Rows[n].Cells[1].Value = "MotorCycle";
            }

            //Model (False = Car , True = Motorcyle)
            if (chkBxIsBike.Checked == false)
            {
                if(cmbBxVehType.Text != "" )
                {
                    dGrdViewList.Rows[n].Cells[2].Value = cmbBxVehType.Text;
                }
                else
                {
                    dGrdViewList.Rows[n].Cells[2].Value = "Car Model";
                }
            }
            else
            {
                if (cmbBxVehType.Text != "")
                {
                    dGrdViewList.Rows[n].Cells[2].Value = cmbBxVehType.Text;
                }
                else
                {
                    dGrdViewList.Rows[n].Cells[2].Value = "Motorcycle Model";
                }
            }
            //Time In
            dGrdViewList.Rows[n].Cells[3].Value = lblDigitalClock.Text;
            //Duration
            dGrdViewList.Rows[n].Cells[4].Value = lblResult.Text;
        }


 private void FrontPage_Load(object sender, EventArgs e)
        {
            //Starting the digital clock
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                lblDigitalClock.Text = DateTime.Now.ToString("HH:mm:ss");
            }));
        }

            dGrdViewList.DataSource = null;
            dGrdViewList.DataSource = carList;
      

        public void TimeConverter() //#M001
        {
            DateTime intime = DateTime.Parse(lblTimeReg.Text);
            DateTime outtime = DateTime.Parse(lblTimeRegEnd.Text);
            DateTime conttime = DateTime.Parse(lblDigitalClock.Text);
            float duration = float.Parse((conttime - intime).TotalSeconds.ToString());
            var span = System.TimeSpan.FromMinutes(duration);
            var hour = ((int)span.TotalHours).ToString();
            var minute = span.Minutes.ToString();
            var seconds = span.Seconds.ToString();
            lblResult.Text = $" {seconds} secs";
            lblCost.Text = $"$ {Convert.ToDouble(seconds) * 0.15} ";
        }



             * int c = 0;
            int n = dGrdViewList.Rows.Add();
            dGrdViewList.Rows[n].Cells[0].Value = carList[c].Tag;
            dGrdViewList.Rows[n].Cells[1].Value = carList[c].Type;
            dGrdViewList.Rows[n].Cells[2].Value = carList[c].TimeIn;
            dGrdViewList.Rows[n].Cells[3].Value = carList[c].Duration;
            dGrdViewList.Rows[n].Cells[4].Value = carList[c].Payment;
            c++;
            

vehBox.pnlVCMenu.BackColor = Color.DarkRed;

public bool PanelOpen(bool pEnable) //#M002
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

this was in the interface:
        
        String Type { get; }
        String Model { get; }
        String Duration { get; }
        String Payment { get; }
        

            if (carList.Count <= 0)
            {
                MessageBox.Show("Ahhh");
            }
            else
            {
                string delete = dGrdViewList.SelectedCells[0].Value.ToString();
                carList.RemoveAll(car => car.Tag == delete);
                Display();
            }

dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value
            string delete = dGrdViewList.SelectedCells[0].Value.ToString();

dGrdViewList.DataSource = null;
            dGrdViewList.DataSource = carList; 

 //int selectedIndex = dGrdViewList.CurrentCell.RowIndex;
            //string delete = dGrdViewList.Rows[selectedIndex].Cells[0].Value.ToString();
            string delete = dGrdViewList.SelectedCells[0].Value.ToString();
            carList.RemoveAll(car => car.Tag == delete);
            //dGrdViewList.Rows.RemoveAt(selectedIndex);
            //dGrdViewList.Refresh();



int n = dGrdViewList.Rows.Add();
            dGrdViewList.Rows[n].Cells[0].Value = carList[c].Tag;
            dGrdViewList.Rows[n].Cells[1].Value = carList[c].Type;
            dGrdViewList.Rows[n].Cells[2].Value = carList[c].Model;
            dGrdViewList.Rows[n].Cells[3].Value = carList[c].TimeIn;
            dGrdViewList.Rows[n].Cells[4].Value = carList[c].Duration;
            dGrdViewList.Rows[n].Cells[5].Value = carList[c].Payment;
            c++;
//This code change the Background colour of panelTick
            if (pnlTick.BackColor == Color.Navy)
            {
                pnlTick.BackColor = Color.Blue;
            }
            else
            {
                pnlTick.BackColor = Color.Navy;
            }

            //Printing timer interval
            lblInterval.Text = Convert.ToString(timerDigClock.Interval);

        
        public void PanelOpen() //#M002
        {
           // Need assistance, because the digital clock is not being transported to the AddVehicleBox
           // neither Display is showing its info
            
            AddVehicleBox addVehicle = new AddVehicleBox(carList);
            addVehicle.StartPosition = FormStartPosition.CenterParent;
            addVehicle.ShowDialog(this);
            
        }

*/
