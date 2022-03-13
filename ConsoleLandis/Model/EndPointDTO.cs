using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleLandis.Model
{
    public class EndPointDTO
    {
        [Required]
        public string SerialNumber { get; set; }
        public TypeMeterModel MeterModelId { get; set; }
        public int MeterNumber { get; set; }
        public string MeterFirmwareVersion { get; set; }
        public TypeSwitchState SwitchState { get; set; }
    }

    public enum TypeMeterModel
    {
        NSX1P2W = 16,
        NSX1P3W = 17,
        NSX2P3W = 18,
        NSX3P4W = 19
    }

    public enum TypeSwitchState
    {
        Disconnected = 0,
        Connected = 1,
        Armed = 2
    }
}
