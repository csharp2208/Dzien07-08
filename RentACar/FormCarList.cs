using MySql.Data.MySqlClient;
using RentACar.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class FormCarList : Form
    {

        BindingSource bSource = new BindingSource();

        public FormCarList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Pobiera dane z bazy za pomocą SQL SELECT
        /// </summary>
        public void RefreshData()
        {
            String sql = @"SELECT 
                 c.id, b.name AS brand, m.name AS model,  t.name AS car_type, c.registration_plate, c.engine,
                 c.manufacturer_year, c.avail, c.fuel  
                FROM cars AS c, car_types AS t, car_models AS m , car_brands AS b
                WHERE
                 c.type_id=t.id AND m.id=c.model_id AND m.brand_id=b.id
                ";
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(sql, GlobalData.connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            bSource.DataSource = dt;
            grid.DataSource = bSource;

        }

        private void FormCarList_Load(object sender, EventArgs e)
        {
            RefreshData();
            grid.Columns["id"].HeaderText = "ID";
            grid.Columns["brand"].HeaderText = "Marka";
            grid.Columns["model"].HeaderText = "Model";
            grid.Columns["car_type"].HeaderText = "Własność";
            grid.Columns["registration_plate"].HeaderText = "Nr rejestracyjny";
            
            grid.Columns["engine"].HeaderText = "Poj. silnika";
            grid.Columns["engine"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            grid.Columns["manufacturer_year"].HeaderText = "Rok produkcji";
            grid.Columns["avail"].HeaderText = "Dostępny";
            grid.Columns["fuel"].HeaderText = "Paliwo";

        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == grid.Columns["avail"].Index)
            {
               e.Value = (Convert.ToInt32(e.Value) == 1) ? "TAK" : "NIE";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void mnuRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
