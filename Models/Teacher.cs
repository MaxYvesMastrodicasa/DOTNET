namespace mvc.Models;

public class Teacher
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int Age { get; set; }
    public Major Major { get; set; }
    public string Mail { get; set; }
    public string Password { get; set; }
}
