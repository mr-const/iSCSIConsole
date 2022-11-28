using System;
using System.Collections.Generic;
using System.Text;

namespace DiskAccessLibrary
{
    internal class OpticalDiskImage : RawDiskImage
    {
        public const int DefaultIsoBlockSize = 2048;

        public OpticalDiskImage(string rawDiskImagePath) : base(rawDiskImagePath, DefaultIsoBlockSize, true)
        {
        }

        public override PeripheralDeviceType GetPeripheralDeviceType()
        {
            return PeripheralDeviceType.CDRomDevice;
        }
    }
}
