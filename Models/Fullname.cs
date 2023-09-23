namespace Models
{
    public class Fullname
    {
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public Fullname() { }
        public Fullname(string fullName) 
        {
            var data = fullName?.Split(' ');
            FirstName = data[data.Length - 1];
            LastName= data[0];
            var mid = ""; 
            for (int i = 1; i < data.Length - 2; i++)
            {
                mid += data[i] + " ";
            }
            MidName = mid.TrimEnd();
        }
        public Fullname(string firstName, string midName, string lastName)
        {
            FirstName = firstName;
            MidName = midName;
            LastName = lastName;
        }
    }
}
