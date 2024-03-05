namespace PS_45_GavraKadabra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("JOro", "123", UserRolesEnum.ADMIN);
            UserViewModel uvm1 = new UserViewModel(user1);
            UserView uv = new UserView(uvm1);

            uv.Display();
        }
    }
}