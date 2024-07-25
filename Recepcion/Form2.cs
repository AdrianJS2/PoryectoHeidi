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
using Mysqlx.Crud;
using MySqlX.XDevAPI;

namespace Recepcion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

            Consultas consultas = new Consultas();

            consultas.agregar(textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);

            MySqlDataReader ver;
            ver = consultas.leer();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            if (ver.HasRows)
            {
                while (ver.Read())
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = ver.GetValue(0);
                    dataGridView1.Rows[n].Cells[1].Value = ver.GetString(1);
                    dataGridView1.Rows[n].Cells[2].Value = ver.GetString(2);
                    dataGridView1.Rows[n].Cells[3].Value = ver.GetString(3);
                    dataGridView1.Rows[n].Cells[4].Value = ver.GetString(4);

                }
            }
            consultas.cerrar();





        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();

            MySqlDataReader ver;
            ver = consultas.busca(textBox11.Text);
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();

            if (ver.HasRows)
            {
                while (ver.Read())
                {
                    int n = dataGridView3.Rows.Add();

                    dataGridView3.Rows[n].Cells[0].Value = ver.GetValue(0);
                    dataGridView3.Rows[n].Cells[1].Value = ver.GetString(1);
                    dataGridView3.Rows[n].Cells[2].Value = ver.GetString(2);
                    dataGridView3.Rows[n].Cells[3].Value = ver.GetString(3);
                    dataGridView1.Rows[n].Cells[4].Value = ver.GetString(4);
                }
            }
            consultas.cerrar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(label8.Text);
            Consultas consultas = new Consultas();
            consultas.modificar(id, textBox11.Text, textBox8.Text, textBox9.Text, textBox10.Text);
            MessageBox.Show("Actualizado con exito");
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            label8.Text = dataGridView3.Rows[n].Cells[0].Value.ToString();
            textBox8.Text = dataGridView3.Rows[n].Cells[1].Value.ToString();
            textBox9.Text = dataGridView3.Rows[n].Cells[2].Value.ToString();
            textBox10.Text = dataGridView3.Rows[n].Cells[3].Value.ToString();
            textBox7.Text = dataGridView3.Rows[n].Cells[4].Value.ToString();

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl1.TabPages[e.Index];
            e.Graphics.FillRectangle(new SolidBrush(page.BackColor), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, e.Font, paddedBounds, page.ForeColor);
        }

       
            

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
                
            
        } 

        private void Buscar_Click(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_nombre_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    } 
}
