using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1_EDT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    private void btnCalcular_Click_1(object sender, EventArgs e)
        {
           
            getBits(); 
        }

        // Recorrido a travez de la cifra
        public void getBits()
        {
            Int32 sensor1 = 1;
            Int32 sensor2 = 1;
            Int32 level = 3;
            Int32 direction = 7;
            Int32 day = 31;
            Int32 mes = 15;
            Int32 year = 127;
            

            int input = Convert.ToInt32(txtNumero.Text);
            //reccore un bit 
            input >>= 1;

            direction = (byte)(input & direction);
            input = input >> 3;

            level = (byte)(input & level);
            input = input >> 2;

            sensor1 = (byte)(input & sensor1);
            input = input >> 1;

            sensor2 = (byte)(input & sensor2);
            input = input >> 1;

            day = (byte)(input & day);
            input = input >> 5;

            mes = (byte)(input & mes);
            input = input >> 4;

            year = (byte)(input & year);
            input = year + 1900;

            mostrarDireccion(direction, level, sensor1, sensor2);
            showDate(day, mes, year + 1900);
            
        }
        /// <summary>
        /// Muestra la direccion 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="_lev"></param>
        /// <param name="_sensor1"></param>
        /// <param name="_sensor2"></param>
        public void mostrarDireccion(int d, int _lev, int _sensor1, int _sensor2)
        {
            switch (d)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Luis Espindola\\Downloads\\Practica_1_EDT-20180224T041631Z-001\\Practica_1_EDT\\Practica_1_EDT\\Resources\\N.png");
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Luis Espindola\\Downloads\\Practica_1_EDT-20180224T041631Z-001\\Practica_1_EDT\\Practica_1_EDT\\Resources\\NE.png");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Luis Espindola\\Downloads\\Practica_1_EDT-20180224T041631Z-001\\Practica_1_EDT\\Practica_1_EDT\\Resources\\E.png");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Luis Espindola\\Downloads\\Practica_1_EDT-20180224T041631Z-001\\Practica_1_EDT\\Practica_1_EDT\\Resources\\SE.png");
                    break;
                case 4:
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Luis Espindola\\Downloads\\Practica_1_EDT-20180224T041631Z-001\\Practica_1_EDT\\Practica_1_EDT\\Resources\\S.png");
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Luis Espindola\\Downloads\\Practica_1_EDT-20180224T041631Z-001\\Practica_1_EDT\\Practica_1_EDT\\Resources\\SO.png");
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Luis Espindola\\Downloads\\Practica_1_EDT-20180224T041631Z-001\\Practica_1_EDT\\Practica_1_EDT\\Resources\\O.png");
                    break;
                case 7:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Luis Espindola\\Downloads\\Practica_1_EDT-20180224T041631Z-001\\Practica_1_EDT\\Practica_1_EDT\\Resources\\NO.png");
                    break;
            }

            switch (_lev)
            {
                case 0:
                    txtNivDeTanque.Text = "empty";
                    break;

                case 1:
                    txtNivDeTanque.Text = "Mid";
                    break;

                case 2:
                    txtNivDeTanque.Text = "Full";
                    break;

                case 3:
                    txtNivDeTanque.Text = "Fil up";
                    break;
            }

            if (_sensor1 == 1)
                txtSensorUno.Text = "ON";
            else
                txtSensorUno.Text = "OFF";

            if (_sensor2 == 1)
                txtSensor2.Text = "ON";
            else
                txtSensor2.Text = "OFF";
        }
        /// <summary>
        /// Muestra la fecha
        /// </summary>
        /// <param name="_day">Toma el valor para Día</param>
        /// <param name="_ms">Toma el valor para Mes</param>
        /// <param name="_year">Toma el valor para el Año</param>
        //muestra la fecha
        public void showDate(int _day, int _ms, int _year)
        {
            lblFecha.Text = _day + " / " + _ms + " / " + _year;
        }

        /// <summary>
        /// Obtiene el valor de la fecha
        /// </summary>
        /// <returns></returns>
        public int sacarValorFecha(int tag, int monat, int jahr)
        {
            int dat = 0;
            jahr -= 1900;

            dat = (byte)(tag);
            monat >>= 4;

            dat = dat | monat;
            jahr <<= 9;
            dat = dat | jahr;

            return dat;
        }

        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            int dd = dtpFechas.Value.Day;
            int mm = dtpFechas.Value.Month;
            int yy = dtpFechas.Value.Year;

            txtFechaFinal.Text = Convert.ToString(sacarValorFecha(dd, mm, yy));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
