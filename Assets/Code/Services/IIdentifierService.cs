namespace Code.Services
{
    public interface IIdentifierService
    {
        int Next(Identity identity);
    }
    
    public enum Identity
    {
        General,
        Structure,
        Slot
    }
}