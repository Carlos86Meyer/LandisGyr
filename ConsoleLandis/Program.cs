using ConsoleLandis.Model;
using ConsoleLandis.Control;
using System;
using System.Collections.Generic;

namespace ConsoleLandis
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<EndPointDTO> endPointDTOs = new List<EndPointDTO>();
            //Call the menu
            MainBO mainBO = new MainBO();            
            mainBO.ShowMenu(endPointDTOs);
        }

    }
}
