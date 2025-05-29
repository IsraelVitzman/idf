using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace OOP_project_idf
{
    internal class ManagerProject 
    {
        static void Main(string[] args)
        {
            InformationAboutTheArmy informationAboutTheArmy=new InformationAboutTheArmy();
            Ahman ahman = new Ahman();
            attackManager attackManager = new attackManager();
            Hamas hamas = new Hamas();
            while (true)
            {
                Console.WriteLine("Enter choice:");
                Console.WriteLine("1 - Most alerts");
                Console.WriteLine("2 - Add terrorist report");
                Console.WriteLine("3 - System status");
                Console.WriteLine("4 - Attack terrorist");
                Console.WriteLine("5 - Add new terrorist ");
                Console.WriteLine("6 - sohw all terrorist");
                Console.WriteLine("hader");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine(ahman.mostAlerts());
                        break;
                    case "2":
                        Console.Write("Enter terrorist name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter choice (1-home, 2-outside): ");
                        string cooch = Console.ReadLine();
                        ahman.addTerorist(name, cooch);
                        break;

                    case "3":
                        attackManager.status();
                        break;

                    case "4":
                        attackManager.attackTerorist();
                        break;

                    case "5":
                        Console.Write("Enter terrorist name to add: ");
                        string terroristName = Console.ReadLine();
                        hamas.addToListTerorist(terroristName);
                        break;

                    case "6":
                        hamas.getListTerorist();
                        break;

                    case "7":
                        Console.WriteLine("Enter choice:");
                        Console.WriteLine("1 - change commandInChief");
                        Console.WriteLine("2 - get commandInChief for hamas");
                        Console.WriteLine("3 - get date Of Establishment");
                        Console.WriteLine("4 - information About The Army idf");

                        var input2 = Console.ReadLine();
                        switch (input2)
                        {
                            case "1":
                                string commandInChief = Console.ReadLine();
                                hamas.setcommandInChief(commandInChief);
                                break;

                            case "2":
                                hamas.getcommandInChief();
                                break;

                             case"3":
                                hamas.getdateOfEstablishment();
                                break;

                             case "4":
                                informationAboutTheArmy.PrintInformation();
                                break;


                        }           
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                     }

                
            }
        }
    }
}
