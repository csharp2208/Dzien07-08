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

        private void mnuDeleteCar_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 0) return;

            DialogResult result = MessageBox.Show("Czy usunąć rekord?", "Pytanie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;
            
            String sql = " DELETE FROM cars WHERE id = @rowID ";

            int selectedIndex = grid.SelectedRows[0].Index;
            int rowID = Convert.ToInt32(grid["id", selectedIndex].Value);

            using (MySqlCommand deleteCommand = new MySqlCommand(sql, GlobalData.connection))
            {
                deleteCommand.Parameters.Add("@rowID", MySqlDbType.Int32);
                deleteCommand.Parameters["@rowID"].Value = rowID;
                deleteCommand.ExecuteNonQuery();
            }
            
            grid.Rows.RemoveAt(selectedIndex);

        }

        private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                // szukaj
                String s = tbFind.Text.Trim().ToUpper();
                if (String.IsNullOrEmpty(s))
                {
                    bSource.Filter = null;
                }
                else
                {
                    bSource.Filter = $" registration_plate LIKE '%{s}%' ";
                    if (bSource.Count == 0)
                    {
                        DialogHelper.I("Brak wyników dla podanego filtru");
                        bSource.RemoveFilter();
                    }
                }
                grid.DataSource = bSource;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            AddNewCar();
        }

        private void AddNewCar()
        {
            FormAddCar form = new FormAddCar();
            if (form.ShowDialog()==DialogResult.OK)
            {
                //odswież dane
                RefreshData();
            }
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 0) return;
            int selectedIndex = grid.SelectedRows[0].Index;
            int rowId = Convert.ToInt32(grid["id", selectedIndex].Value);
            
            FormAddCar form = new FormAddCar();
            form.RowId = rowId;
            if (form.ShowDialog() == DialogResult.OK)
            {
                //odswież dane
                RefreshData();
            }
        }

        private void mnuOper_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 0) return;
            int selectedIndex = grid.SelectedRows[0].Index;
            int rowId = Convert.ToInt32(grid["id", selectedIndex].Value);
            int avail = Convert.ToInt32(grid["avail", selectedIndex].Value);
            String regPlate = grid["registration_plate", selectedIndex].Value.ToString(); ;

            FormOperation form = new FormOperation();
            form.RowId = rowId;
            form.OperBack = (avail == 0);
            form.RegPlate = regPlate;
            if (form.ShowDialog()==DialogResult.OK)
            {
                RefreshData();
            }
        }
    }
}
