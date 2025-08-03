using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    internal class Temas
    {
        public static Color PanelPadre;
        public static Color PanelBotones;
        public static Color BarraTitulo;
        public static Color FuenteIconos;
        public static Color TextBusqueda;
        //Colores Defecto
        private static readonly Color panel1 = Color.FromArgb(0, 0, 0);
        private static readonly Color PanelBotonesD = Color.FromArgb(50, 53, 56);
        private static readonly Color BarraTituloD = Color.FromArgb(82, 87, 92);
        private static readonly Color TextBusquedaD = Color.FromArgb(136, 145, 153);
        private static readonly Color FuenteIconosD = Color.White;

        public static void ElegirTema(string Tema)
        {
            if (Tema == "Defecto")
            {
                PanelPadre = panel1;
                PanelBotones = PanelBotonesD;
                BarraTitulo = BarraTituloD;
                TextBusqueda = TextBusquedaD;
                FuenteIconos = FuenteIconosD;
            }
        }
    }

}
