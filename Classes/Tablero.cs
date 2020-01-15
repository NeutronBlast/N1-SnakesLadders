using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalera.Classes
{
    class Tablero
    {
        private int[] especiales;
        private int[] origen;
        private int[] destino;
        private bool  corrido;
        private String fondo;

        public Tablero()
        {
            this.especiales = new int[3] {0, 0, 0};
            this.origen = new int[1] { 0 };
            this.destino = new int[1] { 0 };
            this.corrido = true;
            this.fondo = "Fondo";
    }
        public Tablero(int i)
        {
            switch (i)
            {
                case 1:
                    this.especiales = new int[3] { 18 , 46 , 85 };
                    this.origen = new int[12] { 5, 9, 23, 36, 49, 48, 56, 62, 69, 82, 87, 96 };
                    this.destino = new int[12] { 35, 51, 42, 5, 7, 86, 8, 83, 91, 20, 66, 38 };
                    this.corrido = true;
                    break;
                case 2:
                    this.especiales = new int[3] { 17 , 45 , 86 };
                    this.origen = new int[21] { 2, 7, 8, 15, 16, 21, 28, 36, 46, 49, 51, 62, 64, 71, 74, 78, 87, 89, 92, 95, 99};
                    this.destino = new int[21] { 38, 14, 31, 26, 6, 42, 84, 44, 25, 11, 67, 19, 60, 91, 53, 98, 94, 68, 88, 75, 80};
                    this.corrido = true;
                    break;
                case 3:
                    this.especiales = new int[3] { 23 , 54 , 88 };
                    this.origen = new int[8] { 6, 17, 50, 53, 61, 64, 79, 96};
                    this.destino = new int[8] { 46, 44, 13, 91, 38, 83, 99, 67};
                    this.corrido = true;
                    break;
                case 4:
                    this.especiales = new int[3] { 13 , 41 , 94 };
                    this.origen = new int[19] {2, 4, 8, 15, 21, 28, 36, 47, 48, 51, 53, 62, 64, 71, 80, 86, 92, 95, 98};
                    this.destino = new int[19] {38, 14, 31, 6, 42, 84, 44, 26, 11, 67, 56, 18, 60, 91, 100, 24, 88, 75, 78};
                    this.corrido = true;
                    break;
                case 5:
                    this.especiales = new int[3] { 12 , 48 , 94 };
                    this.origen = new int[7] {5, 36, 40, 59, 75, 78, 91};
                    this.destino = new int[7] { 32, 25, 19, 99, 97, 55, 54};
                    this.corrido = true;
                    break;
                case 6:
                    this.especiales = new int[3] { 17 , 41 , 81 };
                    this.origen = new int[19] {2, 12, 15, 17, 24, 30, 40, 43, 50, 57, 61, 63, 71, 72, 75, 84, 85, 93, 99};
                    this.destino = new int[19] {22,48,27, 6,  88, 3,  23, 80, 52, 25, 41, 86, 53, 92, 32, 98, 65, 73, 79};
                    this.corrido = true;

                    break;
            }
            this.fondo = String.Concat("tablero-", i, "jpg");
        }

        public String GetFondo()
        {
            return this.fondo;
        }

        public bool CasillaTrampa(int i)
        {
            return this.origen.Contains(i);
        }

        public bool CasillaEspecial(int i)
        {
            return this.especiales.Contains(i);
        }

        public int ObteberDestino(int i)
        {
            return this.destino[Array.IndexOf(this.origen, i)];
        }
    }
}
