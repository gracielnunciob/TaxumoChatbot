namespace TaxumoChatBot.Handlers

{
    public interface IMessengerHandler
    {
        bool MessageHandled(dynamic message);
    }
}