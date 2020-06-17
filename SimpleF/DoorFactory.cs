using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleF
{
    public static class DoorFactory
    {
        public static IDoor MakeDoor(int height, int width)
        {
            return new WoodenDoor(height, width);
        }
    }
}