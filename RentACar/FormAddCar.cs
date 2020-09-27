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

            } catch (Exception exc)
            {
                DialogHelper.E(exc.Message);
            }
        }
    }
}
