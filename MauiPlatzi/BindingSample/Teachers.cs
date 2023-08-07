
namespace MauiPlatzi.BindingSample
{
    public  class Teachers
    {
        private string _name = string.Empty;
        private string _lastname = string.Empty;
        private string _course = string.Empty;

        public string Name { get { return _name; } set { _name = value; } }
        public string LastName { get { return _lastname; } set { _lastname = value; } }
        public string Course { get { return _course; } set { _course = value; } }

        public Teachers(string name, string lastname, string course)
        {
            Name = name;
            LastName = lastname;
            Course = course;    
        }

    }
}
