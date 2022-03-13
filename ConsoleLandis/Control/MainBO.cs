using ConsoleLandis.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLandis.Control
{
    public class MainBO
    {
        public void ShowMenu(IEnumerable<EndPointDTO> endPointDTOs)
        {
            EndPointBO endPointBO = new EndPointBO();
            Console.WriteLine("+====================================================+");
            Console.WriteLine("| Please, choose an option to continue               |");
            Console.WriteLine("| 1 - Insert a new endpoint                          |");
            Console.WriteLine("| 2 - Edit an existing endpoint                      |");
            Console.WriteLine("| 3 - Delete an existing endpoint                    |");
            Console.WriteLine("| 4 - List all endpoints                             |");
            Console.WriteLine("| 5 - Find an endpoint by 'Endpoint Serial Number'   |");
            Console.WriteLine("| 6 - Exit                                           |");
            Console.WriteLine("+====================================================|");


            switch (Console.ReadLine())
            {
                case "1":
                    endPointBO.InsertNewEndPoint(endPointDTOs);
                    break;
                case "2":
                    endPointBO.EditEndPoint(endPointDTOs);
                    break;
                case "3":
                    endPointBO.DeleteEndPoint(endPointDTOs);
                    break;
                case "4":
                    endPointBO.ListEndPoints(endPointDTOs);
                    break;
                case "5":
                    endPointBO.FindEndPoint(endPointDTOs);
                    break;
                case "6":
                    Console.WriteLine("Do you really wanna Exit? 1 = Yes | <> 1 = No");

                    if (Console.ReadLine() == "1")
                    {
                        Environment.Exit(0);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option, please choose again");
                    break;
            }
        }
    }
}
