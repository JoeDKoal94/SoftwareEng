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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            load_table();
        }
        void load_table()
        {
            string constring = "datasource=localhost;Database=software_eng;Uid=root;Pwd=Junior11!;";
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

        private void textBox1_TextChanged(object sender, EventArgs e)//UserName textbox 
        {

        }

        private void button1_Click(object sender, EventArgs e)//Modify button 
        {
            string constring = "datasource=localhost;Database=software_eng;Uid=root;Pwd=Junior11!;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            conDatabase.Open();
            MySqlCommand cmd = conDatabase.CreateCommand();
            cmd.CommandText = @"select count(*) from software_eng.grades_tbl where UserName=@UserName and course_id=@course_id";
            cmd.Parameters.Add(new MySqlParameter("UserName", textBox1.Text));
            cmd.Parameters.Add(new MySqlParameter("course_id", textBox2.Text));
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i > 0)
            {
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    con.Open();
                    using (MySqlCommand cmdData = con.CreateCommand())
                    {
                        MySqlCommand cmdDataBase = new MySqlCommand("UPDATE software_eng.grades_tbl  SET exam_1 = @exam_1, exam_2 = @exam_2, final = @final, final_grade = @final_grade, credits = @credits WHERE(UserName = @UserName AND course_id = @course_id);", conDatabase);
                        cmdDataBase.Parameters.Add(new MySqlParameter("UserName", textBox1.Text));
                        cmdDataBase.Parameters.Add(new MySqlParameter("course_id", textBox2.Text));
                        cmdDataBase.Parameters.Add(new MySqlParameter("exam_1", textBox3.Text));
                        cmdDataBase.Parameters.Add(new MySqlParameter("exam_2", textBox4.Text));
                        cmdDataBase.Parameters.Add(new MySqlParameter("final", textBox5.Text));
                        cmdDataBase.Parameters.Add(new MySqlParameter("final_grade", textBox6.Text));
                        cmdDataBase.Parameters.Add(new MySqlParameter("credits", textBox7.Text));
                        cmdDataBase.ExecuteNonQuery();

                        MySqlCommand comm = conDatabase.CreateCommand();
                        cmd.CommandText = @"select count(*) from software_eng.grades_tbl where UserName=@UserName and course_id=@course_id";



                      
                    }
                }
            }
            else
            {


               

                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    con.Open();
                    using (MySqlCommand cmdData = con.CreateCommand())
                    {

                        MySqlCommand cmdDataBase = new MySqlCommand("INSERT INTO software_eng.grades_tbl(UserName, course_id, exam_1, exam_2, final, final_grade, credits) VALUES(@UserName, @course_id, @exam_1, @exam_2, @final, @final_grade, @credits)", con);
                        cmdDataBase.Parameters.Add(new MySqlParameter("UserName", textBox1.Text));
                        cmdDataBase.Parameters.Add(new MySqlParameter("course_id", textBox2.Text));
                        cmdDataBase.Parameters.Add(new MySqlParameter("exam_1", textBox3.Text));
                        cmdDataBase.Parameters.Add(new MySqlParameter("exam_2", textBox4.Text));
                        cmdDataBase.Parameters.Add(new MySqlParameter("final", textBox5.Text));
                        cmdDataBase.Parameters.Add(new MySqlParameter("final_grade", textBox6.Text));
                        cmdDataBase.Parameters.Add(new MySqlParameter("credits", textBox7.Text));
                        cmdDataBase.ExecuteNonQuery();

                        
                    }
                }
            }


            }

        private void button3_Click(object sender, EventArgs e)//Load
        {
            string constring = "datasource=localhost;Database=software_eng;Uid=root;Pwd=Junior11!;";
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)//Modify button
        {
            string constring = "datasource=localhost;Database=software_eng;Uid=root;Pwd=Junior11!;";

            using (MySqlConnection con = new MySqlConnection(constring))
               {
                   con.Open();
                   using (MySqlCommand cmdData = con.CreateCommand())
                   {

                       MySqlCommand cmdDataBase = new MySqlCommand("INSERT INTO software_eng.grades_tbl(UserName, course_id, exam_1, exam_2, final, final_grade, credits) VALUES(@UserName, @course_id, @exam_1, @exam_2, @final, @final_grade, @credits)", con);
                       cmdDataBase.Parameters.Add(new MySqlParameter("UserName", textBox1.Text));
                       cmdDataBase.Parameters.Add(new MySqlParameter("course_id", textBox2.Text));
                       cmdDataBase.Parameters.Add(new MySqlParameter("exam_1", textBox3.Text));
                       cmdDataBase.Parameters.Add(new MySqlParameter("exam_2", textBox4.Text));
                       cmdDataBase.Parameters.Add(new MySqlParameter("final", textBox5.Text));
                       cmdDataBase.Parameters.Add(new MySqlParameter("final_grade", textBox6.Text));
                       cmdDataBase.Parameters.Add(new MySqlParameter("credits", textBox7.Text));
                       cmdDataBase.ExecuteNonQuery();


                   }
               }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;Database=software_eng;Uid=root;Pwd=Junior11!;";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                using (MySqlCommand cmdData = con.CreateCommand())
                {

                    MySqlCommand cmdDataBase = new MySqlCommand("DELETE FROM software_eng.grades_tbl WHERE UserName = @UserName AND course_id = @course_id", con);
                    cmdDataBase.Parameters.Add(new MySqlParameter("UserName", textBox1.Text));
                    cmdDataBase.Parameters.Add(new MySqlParameter("course_id", textBox2.Text));
                    cmdDataBase.ExecuteNonQuery();


                }
            }
        }
    }
}
