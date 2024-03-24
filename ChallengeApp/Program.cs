User user1 = new User("Adam");
User user2 = new User("Monika");
User user3 = new User("Zuzia");
User user4 = new User("Damian");



class User
{
    private string login;
    private string password;
    private string name;

    // Konstruktor

    public User()
    {
        this.login = "BRAK";
        this.password = "BRAK";
        this.name = "BRAK";
    }
    public User(string login)
    {
        this.login = "Adam";
    }
    public User(string login, string password)
    {
        this.login = "Adam";
        this.password = "password";
    }
}