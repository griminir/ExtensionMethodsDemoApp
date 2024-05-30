using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var room = new HotelRoomModel();

            room.TurnOnAir().SetTemperature(24).OpenShades();

            room.TurnOffAir().CloseShades();

            "hello World".PrintToConsole();

            var person = new PersonModel();
            person.SetDefaultAge().PrintInfo().SetDefaultName("jimmy").PrintInfo();
            Console.ReadLine();
        }
    }
}
