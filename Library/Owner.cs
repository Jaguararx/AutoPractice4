
namespace Library
{
    public class Owner
    {
        public string Country { get; set; }
        private bool hasPermissions;
        public Owner(string country) {
            Country = country;
            hasPermissions = true;
        }
        public void Allow()
        {
            hasPermissions = true;
        }

        public void Deny() {
            hasPermissions = false;
        }

        public string Description() {
            return hasPermissions ? "yes" : "no";
        }
    }
}
