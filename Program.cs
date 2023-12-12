
namespace EventHandler
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the concert event");

            //Creating instances of the classes to subscribe and to raise the event in the publisher
            MusicEvent music = new MusicEvent();

            EventMonitoringCenter monitoringCenter = new EventMonitoringCenter();

            //Subscribing to the events
            monitoringCenter.CallForRegister += music.RegisterEvent;
                                 
            var address = "3456, Olohue Street E, Mississauga, ON L5B 4E8";

            //Initiating the process
            monitoringCenter.OnEventCallReceived(address);

            Console.WriteLine("End of processing the register for concert event");

        }

    }
}