using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1
{
    class Ejercicio_3
    {
        
        private string nombre;
        private float saldoE;
        
        public void menuEje3()
        {
            int op3;
            do
            {
                
                Console.Clear();
                 Console.WriteLine("BANCO CAD.SAS");

                 Console.WriteLine("1. registro de tarjeta");
                 Console.WriteLine("2. consignaciones");
                 Console.WriteLine("3. retiros");
                 Console.WriteLine("4. consultar saldo");
                 Console.WriteLine("5. salir");
                 Console.WriteLine("Seleccione un opcion: ");

                 op3 = int.Parse(Console.ReadLine());

                switch (op3)
                {
                    case 1:

                        GeneraTarjet();
                        registroCliente();
                        AsignarSaldo();
                        mostrarInfo();

                        break;


                    case 2:
                        Consignacion();
                        break;

                    case 3:
                        retirar();
                        break;
                    case 4:
                        cosultarTarjeta();
                        break;
                    case 5:
                        Console.WriteLine("vayase");
                        Console.ReadKey();
                        break;
                }
            }while (op3 != 5);
        }

        private long GeneraTarjet() {

            Console.Clear();


            //se asigna un numero de tarjeta random
            long numeroCuenta;
            
            Random random = new Random();

            long numeroCuentaR = random.Next(111111111, 999999999);


            numeroCuenta = numeroCuentaR;

            return numeroCuenta;

        }

        public void registroCliente()
        {
            
            Console.WriteLine("Digite su nombre por favor"); nombre = Console.ReadLine();
        }

        private float AsignarSaldo()
        {

            //se aplica un saldo random
            float saldo;
            Random random2 = new Random();

            float saldR = random2.Next(1000000,4999999);

            saldo = saldR;
            saldoE = saldo;

            return saldo;
        }


        public void mostrarInfo()
        {
            Console.Clear();
            Console.WriteLine($"Querido cliente {nombre} su tarjeta le ha sido asignada ");
            Console.WriteLine($"con el numero {GeneraTarjet()} y cuenta con un saldo de apertura de {AsignarSaldo()}");
            Console.ReadKey();
        }


        public void Consignacion()
        {
            Console.Clear();
            long CuentaAsignada;
            Console.WriteLine($"por favor {nombre} digite el numero de la cuenta donde se va a realizar la consignacion ");
            CuentaAsignada = long.Parse(Console.ReadLine());

            Console.WriteLine("Digite el monto que desea consignar");
            long montoConsignado = long.Parse(Console.ReadLine());

            if (montoConsignado < saldoE)
            {
                Console.WriteLine("el saldo no es suficiente para realizar la consignacion");
                Console.ReadKey();
            }
            else
            {
               saldoE  = saldoE - montoConsignado;
                Console.WriteLine("el saldo ha sido consignado correctamente");
                Console.ReadKey();
            }
        }


        public void retirar()
        {
            Console.Clear();
            long montoRetirar;
            Console.WriteLine("digite el monto que desea retirar");

            montoRetirar = long.Parse(Console.ReadLine());

            if (montoRetirar > saldoE)
            {
                Console.WriteLine("el saldo no es suficiente para realizar el retiro");
                Console.ReadKey();
            }
            else
            {
                saldoE = saldoE - montoRetirar;
                Console.WriteLine("el saldo ha sido consignado correctamente");
                Console.ReadKey();
            }
        }

        public void cosultarTarjeta()
        {
            Console.Clear();
            Console.WriteLine($"buenas {nombre}");
            Console.WriteLine($"su tarjeta con numero de cuenta {GeneraTarjet()}");
            Console.WriteLine($"actualmente cuenta con saldo de {saldoE}");
        }

    }

}

