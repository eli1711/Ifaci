﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing.Text;

namespace Temp_Arduino
{
    public partial class Termometro : Form
    {
        public Termometro()
        {
            InitializeComponent();//inicializa componentes do formulario
        }

        private void lerTemperatura(object sender, EventArgs e)
        {
            byte[] dados = new byte[2]; //Buffer para dados não definidos
            string valor;
            valor = serialPort1.ReadExisting();
            if (valor != "")
            {
                thermControl1.UpdateControl(Convert.ToInt32(valor));

                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();

            }
            
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler (lerTemperatura));
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            if (TxPorta.Text != "") 
                serialPort1.PortName = TxPorta.Text;
            if (serialPort1.IsOpen)
                serialPort1.Open();
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            
            Application.Exit();
        }
    }
}
