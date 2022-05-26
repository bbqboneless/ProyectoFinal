﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class CapturaPedidos : Form
    {
        public CapturaPedidos(string n,string i)
        {
            InitializeComponent();
            label5.Text = i;
            label7.Text = n;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //obtenemos nuestros productos con cantidad y precio
            string prod1 = labelR.Text.Trim();
            int cant1 = Convert.ToInt32(Math.Round(cantidadR.Value, 0));
            string prod2 = labelP.Text.Trim();
            int cant2 = Convert.ToInt32(Math.Round(cantidadP.Value, 0));
            string prod3 = labelV.Text.Trim();
            int cant3 = Convert.ToInt32(Math.Round(cantidadV.Value, 0));

            PedidosDirector director = new PedidosDirector();

            string file = label7.Text;
            switch (file)
            {
                case "Tienda 1": 
                    PedidosBuilder builderT1 = new Tienda1Builder();
                    director.ConstructPedido(builderT1, prod1, cant1, prod2, cant2, prod3, cant3);
                    Pedidos pedido1 = builderT1.GetPedido();
                    Console.WriteLine("Pedido completado T1: success code {0}", pedido1);
                    break;
                case "Tienda 2": 
                    PedidosBuilder builderT2 = new Tienda2Builder();
                    director.ConstructPedido(builderT2, prod1, cant1, prod2, cant2, prod3, cant3);
                    Pedidos pedido2 = builderT2.GetPedido();
                    Console.WriteLine("Pedido completado T2: success code {0}", pedido2);
                    break;
                case "Tienda 3": 
                    PedidosBuilder builderT3 = new Tienda3Builder();
                    director.ConstructPedido(builderT3, prod1, cant1, prod2, cant2, prod3, cant3);
                    Pedidos pedido3 = builderT3.GetPedido();
                    Console.WriteLine("Pedido completado T3: success code {0}", pedido3);
                    break;
                default: break;
            }

            //PedidosDirector director = new PedidosDirector();
            //PedidosBuilder builderT = new Tienda1Builder();
            //director.ConstructPedido(builderT, prod1, cant1, prod2, cant2, prod3, cant3);
            //Pedidos pedido = builderT.GetPedido();
            //Console.WriteLine("{0}", pedido);
            //Console.WriteLine("Tipo:"+pedido.GetType().ToString());

            MessageBox.Show(label7.Text+"\n Pedido capturado satisfactoriamente! :D");
            new LeerQR().Show();
            Hide();
            //regresamos al principal de leer hasta que se hayan capturado todas las tiendas

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
