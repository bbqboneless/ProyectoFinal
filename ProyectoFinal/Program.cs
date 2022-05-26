﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            string p1 = "Refresco";
            string p2 = "Pan";
            string p3 = "Verduras";
            int c1 = 4;
            int c2 = 7;
            int c3 = 1;
            //Builder
            PedidosDirector director = new PedidosDirector();
            //PedidosBuilder builderT1 = new Tienda1Builder();
            //PedidosBuilder builderT2 = new Tienda2Builder();
            PedidosBuilder builderT3 = new Tienda3Builder();
            //PedidosBuilder builderT4 = new Tienda4Builder();
            director.ConstructPedido(builderT3,p1,c1,p2,c2,p3,c3);
            Pedidos pedido = builderT3.GetPedido();
            Console.WriteLine("{0}", pedido);

            var facade = new SimulationFacade();
            Console.WriteLine("Calling Facade Method Simulation...");
            facade.MethodSim();

            var facade = new SimulationFacade();
            Console.WriteLine("Calling Facade Method Simulation...");
            List<int> list = facade.MethodCam();

            foreach(int i in list)
            {
                Console.WriteLine(i.ToString());
            }

            var facade = new SimulationFacade();
            List<string> list = facade.MethodOrder();

            foreach(string s in list)
            {
                Console.WriteLine(s);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Simulacion());
            
            */


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LeerQR());



        }
    }
}
