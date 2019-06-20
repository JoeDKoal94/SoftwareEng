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
     public partial class Form3 : Form
     {
          public Form3()
          {
               InitializeComponent();
               load_table();
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
               string temp = Form1.variable1;
               MySqlCommand cmdDataBase = new MySqlCommand("select final_grade from grades_tbl where UserName = @UserName;", conDatabase);
               cmdDataBase.Parameters.Add(new MySqlParameter("UserName", temp));
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
               string temp = Form1.variable1;
               MySqlCommand cmdDataBase = new MySqlCommand("select course_name, start_time, end_time, days from courses_tbl, grades_tbl where UserName = @UserName;", conDatabase);
               cmdDataBase.Parameters.Add(new MySqlParameter("UserName", temp));
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
