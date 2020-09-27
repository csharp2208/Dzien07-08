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
    public partial class FormAddCar : Form
    {
        public FormAddCar()
        {
            InitializeComponent();
        }

        private String pictureFileName = null;
        private void btnInsertPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pliki graficzne|*.png;*.jpg;*.jpeg;*.bmp|Pliki GIF|*.gif";
            dialog.FileName = "";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    picCar.Image = new Bitmap(dialog.FileName);
                    pictureFileName = dialog.FileName;
                } catch (Exception exc)
                {
                    DialogHelper.E(exc.Message);
                }
            }
        }

        private void btnRemovePic_Click(object sender, EventArgs e)
        {
            if (picCar.Image!=null)
            {
                picCar.Image.Dispose();
                picCar.Image = null;
                pictureFileName = null;
            }
        }

        private void FormAddCar_Load(object sender, EventArgs e)
        {
            LoadDictionaryData();
        }

        BindingSource bsBrands = new BindingSource();
        BindingSource bsModels = new BindingSource();
        BindingSource bsTypes = new BindingSource();

        private void LoadDictionaryData()
        {
            try
            {
                // ładowanie słownika marek (brandów)
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                String sql = "SELECT * FROM car_brands ORDER BY name";
                adapter.SelectCommand = new MySqlCommand(sql, GlobalData.connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                bsBrands.DataSource = dt;
                cbBrands.DataSource = bsBrands;
                cbBrands.DisplayMember = "name";
                cbBrands.ValueMember = "id";
                cbBrands.SelectedIndex = -1;
                cbBrands.SelectedIndexChanged += CbBrands_SelectedIndexChanged;

                // ładowanie słownika modeli
                sql = " SELECT * FROM car_models ORDER BY name ";
                adapter.SelectCommand = new MySqlCommand(sql, GlobalData.connection);
                dt = new DataTable();
                adapter.Fill(dt);

                bsModels.DataSource = dt;
                cbModels.DataSource = bsModels;
                cbModels.DisplayMember = "name";
                cbModels.ValueMember = "id";
                cbModels.SelectedIndex = -1;
                cbModels.Enabled = false;

                // ładowanie słownika typów własności
                sql = " SELECT * FROM car_types ORDER BY name ";
                adapter.SelectCommand = new MySqlCommand(sql, GlobalData.connection);
                dt = new DataTable();
                adapter.Fill(dt);

                bsTypes.DataSource = dt;
                cbTypes.DataSource = bsTypes;
                cbTypes.DisplayMember = "name";
                cbTypes.ValueMember = "id";
                cbTypes.SelectedIndex = -1;

            } catch (Exception exc)
            {
                DialogHelper.E(exc.Message);
            }
        }

        private void CbBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBrands.SelectedIndex>-1)
            {
                bsModels.Filter = " brand_id = " + cbBrands.SelectedValue;
                cbModels.DataSource = bsModels;
                cbModels.Enabled = true;
                cbModels.SelectedIndex = -1;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                DialogHelper.E("Sprawdź pola formularza");
                return;
            }
            // zapis do bazy
        }

        private bool ValidateData()
        {
            if (cbModels.SelectedIndex>-1 && cbTypes.SelectedIndex>-1 &&
                cbFuel.SelectedIndex>-1 && 
                tbRegPlate.Text.Replace(" ","").Length>=3 )
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
