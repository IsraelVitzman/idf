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
    internal class mangerProjct
    {   
        
        static void Main(string[] args)
        {   Ahman ahman=new Ahman();
            attackManager attackManager=new attackManager();
            Console.WriteLine("");
            var input = Console.ReadLine();
            switch (input) 
            {
                case "1":
                    ahman.mostAlerts();
                    break;
                case "2":
                    string name=Console.ReadLine();
                    string loction = Console.ReadLine();
                    string cooch = Console.ReadLine();
                    
                    ahman.addTerorist(name,loction,cooch );
                    break;

                case "3":
                    attackManager.status();
                    break;
                case "4":
                    attackManager.attackTerorist();
                    break;
                 default:
                    Console.WriteLine("invalid error");
                    break;
            }   
        }
    }
    
}
