using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_tulusa
{
    public partial class Form1 : Form
    {
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AppData\Tooded_DB.mdf;Integrated Security=True");
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded_DB.mdf;Integrated Security=True");
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\tulusa_DB\DB_tulusa\AppData\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter_toode, adapter_kat;
        public Form1()
        {
            InitializeComponent();
            Naita_Andmed();
        }
        public void Kustuta_andmed()
        {
            Toode_txt.Text = " ";
            kogus_num.Value = 0;
            hind_num.Value = 0;
            Kat_cbox.Items.Clear();
        }
        private void lisaKat_btn_Click(object sender, EventArgs e)
        {
            connect.Open();
            cmd = new SqlCommand("INSERT INTO Kategooria (Kategooria_nimetus) VALUES (@kat)",connect);
            cmd.Parameters.AddWithValue("@kat",Kat_cbox.Text);
            cmd.ExecuteNonQuery();
            connect.Close();
            Kustuta_andmed();
            Naita_Kat();
        }
        public void Naita_Kat()
        {
            connect.Open();
            adapter_kat = new SqlDataAdapter("SELECT Kategooria_nimetus from Kategooria", connect);
            DataTable dt_kat = new DataTable();
            adapter_kat.Fill(dt_kat);
            foreach (DataRow nimetus in dt_kat.Rows)
            {
                Kat_cbox.Items.Add(nimetus["Kategooria_nimetus"]);
            }
            connect.Close();
        }
        private void lisa_btn_Click(object sender, EventArgs e)
        {
            string kogus = kogus_num.Value.ToString();
            string hind = hind_num.Value.ToString();
            string path = toode_pbox.ImageLocation;
            FileInfo fi=new FileInfo(path);
            string extn=fi.Extension;
            if (Toode_txt.Text.Trim() != string.Empty && kogus.Trim() != string.Empty && hind.Trim() != string.Empty && Kat_cbox.SelectedItem != null)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Toodetable(Toodenimetus,Kogus,Hind,Pilt ,Kategooria_Id) VALUES (@toode,@kogus,@hind,@pilt,@kat)", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@toode", Toode_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", kogus);
                    cmd.Parameters.AddWithValue("@hind", hind);//format andmebaasis ja vormis võrtsed
                    cmd.Parameters.AddWithValue("@pilt", Toode_txt.Text + extn);//надо сделать проверку формата
                    cmd.Parameters.AddWithValue("@kat", Kat_cbox.SelectedIndex + 1);//id võtta andmebaasist
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Kustuta_andmed();
                    Naita_Andmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga on viga!");
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmeid!!!");
            }
        }
        private void kustuta_btn_Click(object sender, EventArgs e)
        {
            string sql = "";
            DialogResult result = MessageBox.Show("Kustuta kategooria?(Ei=kustuta toode)", "...", MessageBoxButtons.YesNo);
            if (result==DialogResult.No)
            {
                connect.Open();
                if (dataGridView1.SelectedRows.Count == 0) return;
                sql = "DELETE FROM Toodetable WHERE Id=@rowID";

                using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    int rowID = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                    deleteRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = rowID;
                    deleteRecord.ExecuteNonQuery();

                    dataGridView1.Rows.RemoveAt(selectedIndex);
                }
                connect.Close();
            }
            else if (result == DialogResult.Yes)
            {
                connect.Open();
                if (Kat_cbox.Text=="") return;
                sql = "DELETE FROM Kategooria WHERE Kategooria_nimetus=@kat";

                using (SqlCommand deleteRecord=new SqlCommand(sql,connect))
                {
                    deleteRecord.Parameters.AddWithValue("@kat", Kat_cbox.Text);
                    deleteRecord.ExecuteNonQuery();
                }
                Kustuta_andmed();
                connect.Close();
                Naita_Kat();
            }
        }
        SaveFileDialog save;
        OpenFileDialog open;
        private void Otsi_btn_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();

            open.InitialDirectory = @"C:\Users\opilane\Downloads";
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            FileInfo open_info = new FileInfo(@"C:\Users\opilane\Downloads\" + open.FileName);
            if (open.ShowDialog() == DialogResult.OK && Toode_txt != null)
            {
                
                save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..\Images");
                save.FileName = Toode_txt.Text + Path.GetExtension(open.FileName); //".jpg";            
                save.Filter = "Image Files" + Path.GetExtension(open.FileName) + "|" + Path.GetExtension(open.FileName);


                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(open.FileName, save.FileName);
                    save.RestoreDirectory = true;
                    toode_pbox.Image = Image.FromFile(save.FileName);
                }
            }
        }
        private void uuenda_btn_Click(object sender, EventArgs e)
        {
            string kogus = kogus_num.Value.ToString();
            string hind = hind_num.Value.ToString();
            if (Toode_txt.Text.Trim() == string.Empty || kogus.Trim() == string.Empty || hind.Trim() == string.Empty || Kat_cbox.SelectedItem != null)
            {
                try
                {
                    connect.Open();
                    if (dataGridView1.SelectedRows.Count == 0) return;

                    using (SqlCommand deleteRecord = new SqlCommand("DELETE FROM Toodetable WHERE Id=@rowID", connect))
                    {
                        int selectedIndex = dataGridView1.SelectedRows[0].Index;
                        int rowID = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                        deleteRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = rowID;
                        deleteRecord.ExecuteNonQuery();

                        dataGridView1.Rows.RemoveAt(selectedIndex);
                    }
                    connect.Close();

                    cmd = new SqlCommand("INSERT INTO Toodetable(Toodenimetus,Kogus,Hind,Pilt,Kategooria_Id) VALUES (@toode,@kogus,@hind,@pilt,@kat)", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@toode", Toode_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", kogus);
                    cmd.Parameters.AddWithValue("@hind", hind);//format andmebaasis ja vormis võrtsed
                    cmd.Parameters.AddWithValue("@pilt", Toode_txt.Text + ".jpg");//надо сделать проверку формата
                    cmd.Parameters.AddWithValue("@kat", Kat_cbox.SelectedIndex + 1);//id võtta andmebaasist
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Kustuta_andmed();
                    Naita_Andmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga on viga!");
                }
            }
        }
        int Id;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //если выбрать пустую строку, то будет ошибка
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Toode_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            kogus_num.Value = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            hind_num.Value = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            try
            {
                toode_pbox.Image = Image.FromFile(@"..\..\Images\" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Kas tahad lisada pilti?", "Fail puudub!", MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    open = new OpenFileDialog();

                    open.InitialDirectory = @"C:\Users\opilane\Downloads";
                    open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                    FileInfo open_info = new FileInfo(@"C:\Users\opilane\Downloads\" + open.FileName);
                    if (open.ShowDialog() == DialogResult.OK && Toode_txt != null)
                    {
                        save = new SaveFileDialog();
                        save.InitialDirectory = Path.GetFullPath(@"..\..\Images");
                        save.FileName = Toode_txt.Text + Path.GetExtension(open.FileName); //".jpg";            
                        save.Filter = "Image Files" + Path.GetExtension(open.FileName) + "|" + Path.GetExtension(open.FileName);


                        if (save.ShowDialog() == DialogResult.OK)
                        {
                            File.Copy(open.FileName, save.FileName);
                            save.RestoreDirectory = true;
                            toode_pbox.Image = Image.FromFile(save.FileName);
                        }
                    }
                }
                else
                {
                    toode_pbox.Image = Image.FromFile("../../Images/file.png");
                    MessageBox.Show("Nagu soovid");
                }
            }
            string v = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Kat_cbox.SelectedIndex = int.Parse(v) - 1;
        }
        public void Naita_Andmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT * FROM Toodetable",connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.DataSource = dt_toode;

            toode_pbox.Image = Image.FromFile("../../Images/file.png");
            connect.Close();
            Naita_Kat();
        }
    }
}