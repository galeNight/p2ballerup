namespace Api.classes
{
    public class Person
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateOnly Bday { get; set; }
        public bool IsEditing { get; set; } = false;
    }
}