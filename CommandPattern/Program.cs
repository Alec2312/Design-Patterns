using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor(new Light("Garage light"));
            Stereo stereo = new Stereo();
            // Define and instantiate an Off and On command for each Vendor class

            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */
            remoteControl.SetCommand(0, new LightOnCommand(livingRoomLight), new LightOffCommand(livingRoomLight));
            remoteControl.SetCommand(1, new LightOnCommand(kitchenLight), new LightOffCommand(kitchenLight));
            remoteControl.SetCommand(2, new CeilingFanHighCommand(livingRoomCeilingFan), new CeilingFanOffCommand(livingRoomCeilingFan));
            remoteControl.SetCommand(3, new GarageDoorUpCommand(garageDoor), new GarageDoorDownCommand(garageDoor));
            remoteControl.SetCommand(4, new StereoOnWithCdCommand(stereo), new StereoOffCommand(stereo));

            Console.WriteLine(remoteControl);

            // Test the pressing of Buttons here. Don't forget to test the Undo button

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(3);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.OnButtonWasPushed(2);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OnButtonWasPushed(4);
            remoteControl.UndoButtonWasPushed();
            Console.ReadLine();
        }
    }
}