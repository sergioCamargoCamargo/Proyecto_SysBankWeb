using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class AppConfiguration
    {
        public string SysbankDB { get; set; }
        public static AppConfiguration Instance { get; } = new AppConfiguration();
    }
}
