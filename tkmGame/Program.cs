using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tkmGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("taş   için '1'");
            Console.WriteLine("kağıt için '2'");
            Console.WriteLine("makas için '3'");

            int userPuan = 0;
            int pcPuan = 0;


            while (true)
            {
                if (pcPuan == 2 || userPuan == 2)
                {
                    break;
                }
                else
                {
                    Console.Write("user : ");
                    int user = Convert.ToInt32(Console.ReadLine());
                    int pc = random.Next(1, 4);
                    Console.WriteLine("pc :  {0} ", pc);

                    switch (pc)
                    {

                        case 1:
                            if (user == 1)
                            {


                                Console.WriteLine("kullanıcı taş seçti");
                                Console.WriteLine("pc taş seçti");
                                Console.WriteLine("berabere");
                            }

                            else if (user == 2)
                            {
                                Console.WriteLine("kullanıcı kağıt seçti");
                                Console.WriteLine("pc taş seçti");
                                Console.WriteLine("kullanıcı kazandı");
                                userPuan++;

                            }
                            else if (user == 3)
                            {
                                Console.WriteLine("kullanıcı makas seçti");
                                Console.WriteLine("pc taş seçti");
                                Console.WriteLine("kazanan pc");
                                pcPuan++;

                            }
                            break;
                        case 2:
                            if (user == 1)
                            {


                                Console.WriteLine("kullanıcı taş seçti");
                                Console.WriteLine("pc kağıt seçti");
                                Console.WriteLine("pc kazandı");
                                pcPuan++;
                            }

                            else if (user == 2)
                            {
                                Console.WriteLine("kullanıcı kağıt seçti");
                                Console.WriteLine("pc kağıt seçti");
                                Console.WriteLine("berabere");

                            }
                            else if (user == 3)
                            {
                                Console.WriteLine("kullanıcı makas seçti");
                                Console.WriteLine("pc kağıt seçti");
                                Console.WriteLine("kullanıcı kazandı");
                                userPuan++;

                            }
                            break;
                        case 3:
                            if (user == 1)
                            {


                                Console.WriteLine("kullanıcı taş seçti");
                                Console.WriteLine("pc makas seçti");
                                Console.WriteLine("kullanıcı kazandı");
                                userPuan++;

                            }

                            else if (user == 2)
                            {
                                Console.WriteLine("kullanıcı kağıt seçti");
                                Console.WriteLine("pc makas seçti");
                                Console.WriteLine("pc kazandı");
                                pcPuan++;

                            }
                            else if (user == 3)
                            {
                                Console.WriteLine("kullanıcı makas seçti");
                                Console.WriteLine("pc makas seçti");
                                Console.WriteLine("berabere");
                            }
                            break;


                    }

                }
            }
            Console.Clear();




            Console.Write($"  SKOR  : Kullanıcı - {userPuan} - {pcPuan} PC");
            Console.ReadLine();
        }

    }


}















