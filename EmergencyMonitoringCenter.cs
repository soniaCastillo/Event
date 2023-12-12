namespace EventHandler;

public delegate void musicEvent(object sender, EventInfo e);

public class EventMonitoringCenter
{
    //Creating the event
    public event musicEvent CallForRegister;

    public void OnEventCallReceived(string address)
    {
            
        var eventInfo = new EventInfo(address);
        ProcessingCallCompleted(this, eventInfo);
    }

    public void ProcessingCallCompleted(object sender,EventInfo e)
    {
        CallForRegister?.Invoke(this,e);
    }
}