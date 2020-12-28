using System;
using System.Collections.Generic;
using System.Text;

namespace ArghOS.Utils
{
	public class VMwareSVGDrivers
	{
        public static void InitGUI()
        {
            Cosmos.HAL.Drivers.PCI.Video.VMWareSVGAII driver = new Cosmos.HAL.Drivers.PCI.Video.VMWareSVGAII();
            driver.SetMode(800, 600);
            driver.Clear(0x255);
        }
    }
}
