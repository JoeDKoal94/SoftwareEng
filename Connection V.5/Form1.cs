﻿using System;
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
     public partial class MainLog : Form
     {
        public static string variable1;
        public MainLog()
          {
               InitializeComponent();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               string ConnectionString = "Server=localhost;Database=software_project;Uid=root;Pwd=zero00;";
               using (MySqlConnection con = new MySqlConnection(ConnectionString))
               {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                         cmd.CommandText = @"select count(*) from students_tbl where UserName=@UserName and Password=@Password";
                         cmd.Parameters.Add(new MySqlParameter("UserName", textBox1.Text));
                         MainLog.variable1 = textBox1.Text;
                         cmd.Parameters.Add(new MySqlParameter("Password", textBox2.Text));
                         int i = Convert.ToInt32(cmd.ExecuteScalar());
                         if (i > 0)
                         {
                              UHD f3 = new UHD();
                              f3.ShowDialog();
                         }
                         else
                         {
                              MessageBox.Show("UserName or Password error.");
                         }
                    }
               }
          }

          private void button2_Click(object sender, EventArgs e)
          {
               string ConnectionString = "Server=localhost;Database=software_project;Uid=root;Pwd=zero00;";
               using (MySqlConnection con = new MySqlConnection(ConnectionString))
               {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                         cmd.CommandText = @"select count(*) from admin_tbl where UserName=@UserName and Password=@Password";
                         cmd.Parameters.Add(new MySqlParameter("UserName", textBox1.Text));
                         cmd.Parameters.Add(new MySqlParameter("Password", textBox2.Text));
                         int i = Convert.ToInt32(cmd.ExecuteScalar());
                         if (i > 0)
                         {
                              Form2 f2 = new Form2();
                              f2.ShowDialog();
                         }
                         else
                         {
                              MessageBox.Show("UserName or Password error.");
                         }
                    }
               }
          }
     }
}
