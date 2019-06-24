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
                string temp = Form1.variable1;
                label1.Text = temp;
                load_labels();
        }
        void load_labels()
        {
            string constring = "datasource=localhost;Database=software_eng;Uid=root;Pwd=Junior11!;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            conDatabase.Open();
            string temp = Form1.variable1;
            MySqlCommand cmdDataBase = new MySqlCommand("select first_name, last_name from students_tbl where UserName = @UserName;", conDatabase);
            cmdDataBase.Parameters.Add(new MySqlParameter("UserName", temp));
            MySqlDataReader dr = cmdDataBase.ExecuteReader();
            if (dr.Read())
            {

                label2.Text = (dr["first_name"].ToString());
                label3.Text = (dr["last_name"].ToString());
            }
        }
        void load_table()
          {
            string constring = "datasource=localhost;Database=software_eng;Uid=root;Pwd=Junior11!;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            string temp = Form1.variable1;
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT UserName,course_number, course_name, start_time, end_time, days FROM grades_tbl a, courses_tbl b WHERE a.UserName = @UserName AND a.course_id = b.course_id; ; ", conDatabase);
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

          private void button1_Click(object sender, EventArgs e)
          {
            string constring = "datasource=localhost;Database=software_eng;Uid=root;Pwd=Junior11!;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            string temp = Form1.variable1;
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT avg(a.credits) AS GPA FROM grades_tbl a, courses_tbl b WHERE a.UserName = @UserName AND a.course_id = b.course_id;", conDatabase);
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
               string constring = "datasource=localhost;Database=software_eng;Uid=root;Pwd=Junior11!;";
               MySqlConnection conDatabase = new MySqlConnection(constring);
               string temp = Form1.variable1;
               MySqlCommand cmdDataBase = new MySqlCommand("SELECT course_number, course_name, start_time, end_time, days FROM grades_tbl a, courses_tbl b WHERE a.UserName = @UserName AND a.course_id = b.course_id; ; ", conDatabase);
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

        private void button3_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;Database=software_eng;Uid=root;Pwd=Junior11!;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            string temp = Form1.variable1;
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT course_number, course_name, exam_1, exam_2, final, final_grade FROM grades_tbl a, courses_tbl b WHERE a.UserName = @UserName AND a.course_id = b.course_id; ; ", conDatabase);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
