using PasswordManager.AppComposition.Enums;

namespace PasswordManager.AppComposition.Model
{
    public class PasswordGroup : List<Password>
    {
        public string Name { get; private set; }

        public PasswordGroup(string name, List<Password> passwords) : base(passwords)
        {
            Name = name;
        }
    }
}
