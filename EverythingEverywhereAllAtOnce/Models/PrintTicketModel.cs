namespace EverythingEverywhereAllAtOnce.Models;

public class PrintTicketModel
{
    public int Id { get; set; }
    public string? PrintName { get; set; }
    public string? Weight { get; set; }
    public List<Filament> FilamentList { get; set; }
    public int FilamentID { get; set; }
    public List<User> UserList { get; set; }
    public int UserID { get; set; }
    //missing:
    //public image
    //public file
}

public class Filament
{
    public int FilamentID { get; set; }
    public string FilamentName { get; set; }
    public int FilamentWeight { get; set; }

}

public class User
{
    public int UserID { get; set; }
    public string UserName { get; set; }

    //missing:
    //public image
}