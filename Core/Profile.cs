namespace Core
{
    public class Profile
    {
        public Profile(string alias)
        {
            Alias = alias;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Alias { get; private set; }
    }
}