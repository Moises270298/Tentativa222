using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tentativa222
{
    public partial class Form1 : Form

    {
        //Codigo para criar uma conexao com o banco de dados
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-F7VJSUJ\\SQLEXPRESS;Initial Catalog=CadastroEmpresa;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr; // Codigo para ler


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // comando de conexao recebe string de conexao
            comando.Connection = conn;
            CarregarLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "") // AMBOS TEXTBOX TEM QUE SER DIFERENTE DE VAZIO
            {
                // Comando para conexao e inserção de dados do banco com o programa
                //conn.Open();
                comando.CommandText = "Insert into tblEmpresa (IdEmpresa,Nome da Empresa,CPNJ,ENDEREÇO,TELEFONE, Bairro, CEP) values ('" + textBox1.Text + "','" + textBox2.Text + "'+ textBox3.Text,'" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                // comando.ExecuteNonQuery();
                conn.Close(); ;

                CarregarLista();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";


            }

        }

        private void CarregarLista()
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();

            conn.Open();
            comando.CommandText = "Select * From tblEmpresa";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0].ToString());
                    listBox2.Items.Add(dr[1].ToString());
                    listBox3.Items.Add(dr[2].ToString());
                    listBox4.Items.Add(dr[3].ToString());
                    listBox5.Items.Add(dr[4].ToString());
                    listBox6.Items.Add(dr[5].ToString());
                    listBox7.Items.Add(dr[6].ToString());
                }
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label12_TabIndexChanged(object sender, EventArgs e)
        {
            listBox l = sender as listBox;
            //if(l.SelectedIndexChanged != -1)
            {
                //listBox1.SelectedIndex = l.SelectedIndexChanged;
                //listBox2.SelectedIndex = l.SelectedIndexChanged;
                //listBox3.SelectedIndex = l.SelectedIndexChanged;
                //listBox4.SelectedIndex = l.SelectedIndexChanged;
                //listBox5.SelectedIndex = l.SelectedIndexChanged;

                // textBox1.Text = listBox1.SelectedIndex.ToString();
                // textBox2.Text = listBox1.SelectedIndex.ToString();
                // textBox3.Text = listBox1.SelectedIndex.ToString();
                ////textBox4.Text = listBox1.SelectedIndex.ToString();
                //textBox5.Text = listBox1.SelectedIndex.ToString();
                //recebe e converte o item selecionado
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "")
            {
                conn.Open();
               // comando.CommandText = "UPDATE *from tblCadastroEmpresa where IDEMPRESA ='" + textBox1.SE + V + textBox2 + "'AND EMPRESA='" + textBox3 + "'AND ENDEREÇO='" + textBox4 + "'AND TELEFONE='" + textBox5 + "'";
                comando.ExecuteNonQuery();
                conn.Close(); ;

                CarregarLista();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text !="" & textBox4.Text != "" & textBox5.Text != "")
            {
                  conn.Open();
                 // comando.CommandText = "Delete *from tblEmpresa where IDEMPRESA ='" + textBox1.Text + V + textBox2 + "'AND EMPRESA='" + textBox3 + "'AND ENDEREÇO='" + textBox4 + "'AND TELEFONE='" + textBox5 + "'";
                   comando.ExecuteNonQuery();
                  conn.Close(); ;

                  CarregarLista();

                 textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                 textBox4.Text = "";
                 textBox5.Text = "";
                 textBox6.Text = "";
                 textBox7.Text = "";
            }
        }
    }
}
