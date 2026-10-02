namespace MVC_Application.Models
{
    public class Xigrid
    {
      
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.MiddleName + " " + this.LastName;
            }
        }
        public string Address { get; set; }
        public string School { get; set; }
        public string Age { get; set; }
    }
}
