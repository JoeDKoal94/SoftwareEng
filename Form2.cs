using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Connection
{
     public partial class Form2 : Form
     {


          public Form2()
          {
               InitializeComponent();
               load_table();
          }

          private void Form2_Load(object sender, EventArgs e)
          {

          }
          void load_table()
          {
               string constring = "datasource=localhost;Database=software_project;Uid=root;Pwd=zero00;";
               MySqlConnection conDatabase = new MySqlConnection(constring);
               MySqlCommand cmdDataBase = new MySqlCommand("select * from students_tbl ;", conDatabase);

               try
               {

                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                    sda.Update(dbdataset);
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
          }
          private void button1_Click(object sender, EventArgs e)
          {
               string constring = "datasource=localhost;Database=software_project;Uid=root;Pwd=zero00;";
               MySqlConnection conDatabase = new MySqlConnection(constring);
               MySqlCommand cmdDataBase = new MySqlCommand("select * from students_tbl ;", conDatabase);

               try
               {

                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                    sda.Update(dbdataset);
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }








          }

          private void button2_Click(object sender, EventArgs e)
          {
               string constring = "datasource=localhost;Database=software_project;Uid=root;Pwd=zero00;";
               MySqlConnection conDatabase = new MySqlConnection(constring);
               MySqlCommand cmdDataBase = new MySqlCommand("select * from grades_tbl ;", conDatabase);

               try
               {

                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                    sda.Update(dbdataset);
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
          }

          private void button3_Click(object sender, EventArgs e)
          {
               string constring = "datasource=localhost;Database=software_project;Uid=root;Pwd=zero00;";
               MySqlConnection conDatabase = new MySqlConnection(constring);
               MySqlCommand cmdDataBase = new MySqlCommand("select * from courses_tbl ;", conDatabase);

               try
               {

                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                    sda.Update(dbdataset);
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
          }

     }
}
