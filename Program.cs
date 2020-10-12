using System;

namespace saldosyregistros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cuenta = new int[10];
            float[] saldo = new float[10];
            string opc, continuar, ncuenta, busca;
            int index_user = 0, nncuenta, nbusca, i;
            float sinicial, monto;
            bool confirmation = true;
            do
            {

                Console.WriteLine("Bienvenido");
                Console.WriteLine("Para registrar usuario escribe (1)");
                Console.WriteLine("Para recargar una cuenta escribe (2)");
                opc = Console.ReadLine();
                switch (opc)
                {
                    case "1":
              
                        Console.WriteLine("Escribe el número de cuenta");
                        ncuenta = Console.ReadLine();
                        nncuenta = Convert.ToInt32(ncuenta);

                        for (i = 0; i < cuenta.Length; i++)
                        {
                            if (cuenta[i] == nncuenta)
                            {
                                Console.WriteLine("La cuenta ya existe, intente con una nueva");
                                i = cuenta.Length;
                                confirmation = false;
                            }
                        }

                        if (confirmation)
                        {
                            Console.WriteLine("La cuenta es valida");
                            Console.WriteLine();
                            cuenta[index_user] = nncuenta;

                            Console.WriteLine("Escribe el saldo inicial");
                            sinicial = float.Parse(Console.ReadLine());

                            if (sinicial >= 100)
                            {
                                Console.WriteLine("Saldo aprobado");
                                saldo[index_user] = sinicial;
                            }
                            else
                            {
                                Console.WriteLine("El saldo debe de ser mayor a 100 o igual");
                            }
                        }

                        index_user += 1;
                        Console.WriteLine();

                        confirmation = true;

                        break;

                    case "2":
                        Console.WriteLine("Escriba la cuenta que desea recargar");
                        busca = Console.ReadLine();
                        nbusca = Convert.ToInt32(busca);

                        for (i = 0; i < cuenta.Length; i++)
                        {
                            if (cuenta[i] == nbusca)
                            {
                                Console.WriteLine("Su saldo es de $" + saldo[i]);
                                Console.WriteLine("Cuánto desea recargar?");
                                monto = float.Parse(Console.ReadLine());

                                saldo[i] = saldo[i] + monto;

                                Console.WriteLine("Se ha actualizado su saldo");
                                i = cuenta.Length;
                                confirmation = false;
                            }
                        }

                        if (confirmation)
                        {
                            Console.WriteLine("Esa cuenta no existe");
                        }

                        confirmation = true;

                        break;

                    default:
                        Console.WriteLine("Esta cuenta ya existe");

                        break;
                }
                Console.WriteLine("Deseas continuar? si (1) / no (2)");
                continuar = Console.ReadLine();
                Console.WriteLine();
            }
            while (continuar == "1");

            Console.ReadLine();
        }
    }
}
