using ConsoleLandis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLandis.Control
{
    public class EndPointBO
    {
        public EndPointReturnDTO InsertNewEndPoint(IEnumerable<EndPointDTO> endPointDTOs)
        {
            EndPointReturnDTO endPointReturnDTO = new EndPointReturnDTO();
            endPointReturnDTO.ReturnCod = 0;
            endPointReturnDTO.ReturnMessage = "OK";
            bool validatorAux = true;
            string valueAux;
            IEnumerable<EndPointDTO> objDTO;
            try
            {
                Console.WriteLine("Inform the data:");
                EndPointDTO endPointDTO = new EndPointDTO();
                Console.WriteLine("Enter the Serial number:");
                valueAux = Console.ReadLine();
                objDTO = (IEnumerable<EndPointDTO>)endPointDTOs.FirstOrDefault(x => x.SerialNumber == valueAux);
                if (objDTO != null)
                {
                    Console.WriteLine("Serial Number already registered");
                    endPointReturnDTO.ReturnCod = 1;
                    endPointReturnDTO.ReturnMessage = "Serial Number already registered";
                    return endPointReturnDTO;
                }
                endPointDTO.SerialNumber = valueAux;

                while (validatorAux == true)
                {
                    Console.WriteLine("Enter the code for the Meter Model ID:");
                    Console.WriteLine("16 - NSX1P2W");
                    Console.WriteLine("17 - NSX1P3W");
                    Console.WriteLine("18 - NSX2P3W");
                    Console.WriteLine("19 - NSX3P4W");
                    switch (Console.ReadLine())
                    {
                        case "16":
                            endPointDTO.MeterModelId = TypeMeterModel.NSX1P2W;
                            validatorAux = false;
                            break;
                        case "17":
                            endPointDTO.MeterModelId = TypeMeterModel.NSX1P3W;
                            validatorAux = false;
                            break;
                        case "18":
                            endPointDTO.MeterModelId = TypeMeterModel.NSX2P3W;
                            validatorAux = false;
                            break;
                        case "19":
                            endPointDTO.MeterModelId = TypeMeterModel.NSX3P4W;
                            validatorAux = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option, please choose again");
                            break;
                    }
                }

                Console.WriteLine("Enter the value of Meter Number:");
                endPointDTO.MeterNumber = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Meter Firmware Version:");
                endPointDTO.MeterFirmwareVersion = Console.ReadLine();

                validatorAux = true;
                while (validatorAux == true)
                {
                    Console.WriteLine("Enter the value of the Switch State:");
                    Console.WriteLine("0 - Disconnected");
                    Console.WriteLine("1 - Connected");
                    Console.WriteLine("2 - Armed");
                    switch (Console.ReadLine())
                    {
                        case "0":
                            endPointDTO.SwitchState = TypeSwitchState.Disconnected;
                            validatorAux = false;
                            break;
                        case "1":
                            endPointDTO.SwitchState = TypeSwitchState.Connected;
                            validatorAux = false;
                            break;
                        case "2":
                            endPointDTO.SwitchState = TypeSwitchState.Armed;
                            validatorAux = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option, please choose again");
                            break;
                    }
                }
                endPointDTOs.Append(endPointDTO);
            }
            catch (Exception ex)
            {
                endPointReturnDTO.ReturnCod = 1;
                endPointReturnDTO.ReturnMessage = "Error: " + ex;
            }
            return endPointReturnDTO;
        }

        public EndPointReturnDTO EditEndPoint(IEnumerable<EndPointDTO> endPointDTOs)
        {
            EndPointReturnDTO endPointReturnDTO = new EndPointReturnDTO();
            endPointReturnDTO.ReturnCod = 0;
            endPointReturnDTO.ReturnMessage = "OK";
            EndPointDTO endPointDTO = new EndPointDTO();
            bool validatorAux = true;
            string valueAux;
            IEnumerable<EndPointDTO> objDTO;
            try
            {
                while (validatorAux == true) {
                    Console.WriteLine("Inform the SerialNumber of the End Point that you wanna change:");
                    valueAux = Console.ReadLine();


                    objDTO = (IEnumerable<EndPointDTO>)endPointDTOs.FirstOrDefault(x => x.SerialNumber == valueAux);
                    if (objDTO == null) {
                        Console.WriteLine("Serial Number not registered, please informe another value:");
                    }
                    else {
                        validatorAux = false;
                        endPointDTO.SerialNumber = valueAux;
                    }
                }

                Console.WriteLine("Do you want to chang only the Switch State: 1 = Yes | <> 1 = No");
                valueAux = Console.ReadLine();
                if (valueAux != "1")
                {
                    while (validatorAux == true)
                    {
                        Console.WriteLine("Enter the code for the Meter Model ID:");
                        Console.WriteLine("16 - NSX1P2W");
                        Console.WriteLine("17 - NSX1P3W");
                        Console.WriteLine("18 - NSX2P3W");
                        Console.WriteLine("19 - NSX3P4W");
                        switch (Console.ReadLine())
                        {
                            case "16":
                                endPointDTO.MeterModelId = TypeMeterModel.NSX1P2W;
                                validatorAux = false;
                                break;
                            case "17":
                                endPointDTO.MeterModelId = TypeMeterModel.NSX1P3W;
                                validatorAux = false;
                                break;
                            case "18":
                                endPointDTO.MeterModelId = TypeMeterModel.NSX2P3W;
                                validatorAux = false;
                                break;
                            case "19":
                                endPointDTO.MeterModelId = TypeMeterModel.NSX3P4W;
                                validatorAux = false;
                                break;
                            default:
                                Console.WriteLine("Invalid option, please choose again");
                                break;
                        }
                    }

                    Console.WriteLine("Enter the value of Meter Number:");
                    endPointDTO.MeterNumber = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Meter Firmware Version:");
                    endPointDTO.MeterFirmwareVersion = Console.ReadLine();
                }

                validatorAux = true;
                while (validatorAux == true)
                {
                    Console.WriteLine("Enter the value of the Switch State:");
                    Console.WriteLine("0 - Disconnected");
                    Console.WriteLine("1 - Connected");
                    Console.WriteLine("2 - Armed");
                    switch (Console.ReadLine())
                    {
                        case "0":
                            endPointDTO.SwitchState = TypeSwitchState.Disconnected;
                            validatorAux = false;
                            break;
                        case "1":
                            endPointDTO.SwitchState = TypeSwitchState.Connected;
                            validatorAux = false;
                            break;
                        case "2":
                            endPointDTO.SwitchState = TypeSwitchState.Armed;
                            validatorAux = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option, please choose again");
                            break;
                    }
                }
                objDTO = (IEnumerable<EndPointDTO>)endPointDTO;
            }        
            catch (Exception ex)
            {
                endPointReturnDTO.ReturnCod = 1;
                endPointReturnDTO.ReturnMessage = "Error: " + ex;
            }
            return endPointReturnDTO;
        }

        public EndPointReturnDTO DeleteEndPoint(IEnumerable<EndPointDTO> endPointDTOs)
        {
            EndPointReturnDTO endPointReturnDTO = new EndPointReturnDTO();
            endPointReturnDTO.ReturnCod = 0;
            endPointReturnDTO.ReturnMessage = "OK";
            string valueAux;
            IEnumerable<EndPointDTO> objDTO;
            try
            {
                Console.WriteLine("Inform the SerialNumber of the End Point that you wanna delete:");
                valueAux = Console.ReadLine();

                objDTO = (IEnumerable<EndPointDTO>)endPointDTOs.FirstOrDefault(x => x.SerialNumber == valueAux);
                if (objDTO != null)
                {
                    Console.WriteLine("Do you really wanna delete this Endpoint? 1 = Yes | <> 1 = No");

                    if (Console.ReadLine() == "1")
                    {
                        //Don't find how delete item in an object, so I'll create the object without the guy the user want to delete.
                        endPointDTOs = (IEnumerable<EndPointDTO>)endPointDTOs.FirstOrDefault(x => x.SerialNumber != valueAux);
                    }
                }

            }
            catch (Exception ex)
            {
                endPointReturnDTO.ReturnCod = 1;
                endPointReturnDTO.ReturnMessage = "Error: " + ex;
            }
            return endPointReturnDTO;
        }

        public EndPointReturnDTO ListEndPoints(IEnumerable<EndPointDTO> endPointDTOs)
        {
            EndPointReturnDTO endPointReturnDTO = new EndPointReturnDTO();
            endPointReturnDTO.ReturnCod = 0;
            endPointReturnDTO.ReturnMessage = "OK";
            try
            {
                foreach(EndPointDTO objDTO in endPointDTOs)
                {
                    Console.WriteLine(objDTO);
                }
            }
            catch (Exception ex)
            {
                endPointReturnDTO.ReturnCod = 1;
                endPointReturnDTO.ReturnMessage = "Error: " + ex;
            }
            return endPointReturnDTO;
        }

        public EndPointReturnDTO FindEndPoint(IEnumerable<EndPointDTO> endPointDTOs)
        {
            EndPointReturnDTO endPointReturnDTO = new EndPointReturnDTO();
            endPointReturnDTO.ReturnCod = 0;
            endPointReturnDTO.ReturnMessage = "OK";
            string valueAux;
            IEnumerable<EndPointDTO> objDTO;
            try
            {
                Console.WriteLine("Inform the SerialNumber of the End Point that you wanna find:");
                valueAux = Console.ReadLine();

                objDTO = (IEnumerable<EndPointDTO>)endPointDTOs.FirstOrDefault(x => x.SerialNumber == valueAux);
                if (objDTO == null)
                {
                    Console.WriteLine("Serial Number not registered");
                }
                else
                {
                    Console.WriteLine(objDTO);
                }
            }
            catch (Exception ex)
            {
                endPointReturnDTO.ReturnCod = 1;
                endPointReturnDTO.ReturnMessage = "Error: " + ex;
            }
            return endPointReturnDTO;
        }
      

    }
}
