using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Restaurant_Management_And_Billing_System
{
    public partial class MainForm : Form
    {

        string connectionString = @"Server=localhost;Database=bakery_db;Uid=root;Pwd=;";
        int itemID;

                private bool
                btnHomeClick = false,
                btnSalesClick = false,
                btnProductClick = false,
                btnInventoryClick = false
            ;

        #region "FORM OVERRIDE"
        bool moving;
        Point offset;
        Point original;

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            panelTitleBar.Capture = true;
            offset = MousePosition;
            original = this.Location;
        }

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (!moving)
                return;

            int x = original.X + MousePosition.X - offset.X;
            int y = original.Y + MousePosition.Y - offset.Y;

            this.Location = new Point(x, y);
        }

        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            panelTitleBar.Capture = false;
        }

        // [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        // private static extern IntPtr CreateRoundRectRgn
        // (
        //int nLeftRect,
        //int nTopRect,
        //int nRightRect,
        //int nBottomRect,
        //int nWidthEllipse,
        //int nHeightEllipse

        // );
        //protected override void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);
        //    if (m.Msg == WM_NCHITTEST)
        //        m.Result = (IntPtr)(HT_CAPTION);

        //}

        //private const int WM_NCHITTEST = 0x84;
        //private const int HT_CLIENT = 0x1;
        //private const int HT_CAPTION = 0x2;
        #endregion


        private void NavBar()
        {
            panelNav.Height = btnHome.Height;
            panelNav.Top = btnHome.Top;
            panelNav.Left = btnHome.Left;
            if (btnHomeClick == true)
            {
                btnHome.BackColor = Color.FromArgb(46, 51, 73);
                panelNav.Height = btnHome.Height;
                panelNav.Top = btnHome.Top;
                panelNav.Left = btnHome.Left;

                //color switch
                btnSales.BackColor = Color.FromArgb(24, 30, 54);
                btnProduct.BackColor = Color.FromArgb(24, 30, 54);
                btnInventory.BackColor = Color.FromArgb(24, 30, 54);
            }
            if (btnSalesClick == true)
            {
                btnSales.BackColor = Color.FromArgb(46, 51, 73);
                panelNav.Height = btnSales.Height;
                panelNav.Top = btnSales.Top;
                panelNav.Left = btnSales.Left;

                //color switch
                btnHome.BackColor = Color.FromArgb(24, 30, 54);
                btnProduct.BackColor = Color.FromArgb(24, 30, 54);
                btnInventory.BackColor = Color.FromArgb(24, 30, 54);
            }
            if (btnProductClick == true)
            {
                btnProduct.BackColor = Color.FromArgb(46, 51, 73);
                panelNav.Height = btnProduct.Height;
                panelNav.Top = btnProduct.Top;
                panelNav.Left = btnProduct.Left;

                //color switch
                btnHome.BackColor = Color.FromArgb(24, 30, 54);
                btnSales.BackColor = Color.FromArgb(24, 30, 54);
                btnInventory.BackColor = Color.FromArgb(24, 30, 54);
            }
            if (btnInventoryClick == true)
            {
                btnInventory.BackColor = Color.FromArgb(46, 51, 73);
                panelNav.Height = btnInventory.Height;
                panelNav.Top = btnInventory.Top;
                panelNav.Left = btnInventory.Left;

                //color switch
                btnHome.BackColor = Color.FromArgb(24, 30, 54);
                btnSales.BackColor = Color.FromArgb(24, 30, 54);
                btnProduct.BackColor = Color.FromArgb(24, 30, 54);
            }
        }
        #region "NavBar Buttons"
        private void btnHome_Click(object sender, EventArgs e)
        {
            //switch tab
            tabControl1.SelectedTab = tabDash;
            labelHeader.Text = "Dashboard";
            //

            btnHomeClick = true;
            btnSalesClick = false;
            btnProductClick = false;
            btnInventoryClick = false;
            NavBar();
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSales;
            labelHeader.Text = "Sales Report";

            btnHomeClick = false;
            btnSalesClick = true;
            btnProductClick = false;
            btnInventoryClick = false;
            NavBar();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabProduct;
            labelHeader.Text = "Product Management";


            btnHomeClick = false;
            btnSalesClick = false;
            btnProductClick = true;
            btnInventoryClick = false;
            NavBar();
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabInventory;
            labelHeader.Text = "Inventory Management";

            btnHomeClick = false;
            btnSalesClick = false;
            btnProductClick = false;
            btnInventoryClick = true;
            NavBar();
        }
        #endregion
        public MainForm()
        {
            InitializeComponent();
            NavBar();
            var Tab = new TabPadding(tabControl1);
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 6, 6));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridFill();
        }
        #region "Control Menu"
        private void labelMax_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            labelMax.SendToBack();
        }

        private void labelMin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }


        private void labelNormal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            labelNormal.SendToBack();
        }
        #endregion


        #region "Place Holder"
        private void txtBread_Enter(object sender, EventArgs e)
        {

            if (txtBread.Text == "Bread")
            {
                txtBread.Text = "";
                txtBread.ForeColor = Color.White;
            }
        }
        private void txtBread_Leave(object sender, EventArgs e)
        {
            if (txtBread.Text == "")
            {
                txtBread.Text = "Bread";
                txtBread.ForeColor = Color.DimGray;
                txtBread.BottomBorderColor = Color.Gray;
            }
        }
        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (txtPrice.Text == "Price")
            {
                txtPrice.Text = "";
                txtPrice.ForeColor = Color.White;
            }
        }
        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                txtPrice.Text = "Price";
                txtPrice.ForeColor = Color.DimGray;
                txtPrice.BottomBorderColor = Color.Gray;
            }
        }

        private void txtPieces_Enter(object sender, EventArgs e)
        {
            if (txtPieces.Text == "Pieces")
            {
                txtPieces.Text = "";
                txtPieces.ForeColor = Color.White;
            }
        }
        private void txtPieces_Leave(object sender, EventArgs e)
        {
            if (txtPieces.Text == "")
            {
                txtPieces.Text = "Pieces";
                txtPieces.ForeColor = Color.DimGray;
                txtPieces.BottomBorderColor = Color.Gray;
            }
        }



        #endregion


        private void txtClear_Click(object sender, EventArgs e)
        {
                txtBread.Text = "";
                txtPrice.Text = "";
                txtPieces.Text = "";
            btnSave.ButtonText = "Save";

        }

        private void dgvInventory_DoubleClick(object sender, EventArgs e)
        {
           
            if (dgvInventory.CurrentRow.Index != -1)
            {
                itemID = Convert.ToInt32(dgvInventory.CurrentRow.Cells[0].Value.ToString());
                txtBread.Text = dgvInventory.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = dgvInventory.CurrentRow.Cells[2].Value.ToString();
                txtPieces.Text = dgvInventory.CurrentRow.Cells[3].Value.ToString();
                btnSave.ButtonText = "Update";
            }
        }

        private void txtPieces_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void itemDatePicker_onValueChanged_1(object sender, EventArgs e)
        {
            GridFill();
        }

        private void reportDatePicker_onValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Chart();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("insertAndUpdate",mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_ID", itemID);
                mysqlCmd.Parameters.AddWithValue("_Bread", txtBread.Text.Trim()) ;
                mysqlCmd.Parameters.AddWithValue("_Price",txtPrice.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_Qty",txtPieces.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_Date", itemDatePicker.Value);
                mysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully","Message ::",MessageBoxButtons.OK,MessageBoxIcon.Information);
                GridFill();

            }
        }
        ////
        void GridFill()
        {
            using (MySqlConnection mySqlcon = new MySqlConnection(connectionString))
            {
                    mySqlcon.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("getData", mySqlcon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("_datePicker", itemDatePicker.Value.Date.ToString("yyyy/MM/dd"));
                    //sqlDa.SelectCommand.Parameters.AddWithValue("_datePicker", textboxCustom2.Text);
                    DataTable dtblinventory = new DataTable();
                    sqlDa.Fill(dtblinventory);
                    dgvInventory.DataSource = dtblinventory;
                dgvInventory.Columns[0].Visible = false;
            }
        }
        void Chart()
        {
            chart1.Series[0].Points.Clear();
            using (MySqlConnection mySqlcon = new MySqlConnection(connectionString))
            {
                mySqlcon.Open();
                MySqlCommand sqlDa = new MySqlCommand("getReport", mySqlcon);
                sqlDa.CommandType = CommandType.StoredProcedure;
                sqlDa.Parameters.AddWithValue("_Date", reportDatePicker.Value);
                MySqlDataReader myReader;
        try
          {
                    myReader = sqlDa.ExecuteReader();
                    while (myReader.Read())
                    {
                       
                       chart1.Series["Best Seller"].Points.AddXY(myReader.GetString("name"), myReader.GetInt32("SUM(purchase.sold)"));
                       chart1.ChartAreas[0].AxisX.Interval = 1;
                       chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -40;
                       chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                       chart1.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular);                      
                    }

          }
        catch (Exception ex)
         {
                    MessageBox.Show(ex.Message);
          }


            }
        }



    }
}
