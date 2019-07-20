public static class ServiceLocator 
{
    public static readonly ButtonService ButtonService;

    static ServiceLocator()
    {
        ButtonService = new ButtonService();
    }
}