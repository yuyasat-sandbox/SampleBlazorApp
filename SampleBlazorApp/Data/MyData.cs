using System.ComponentModel.DataAnnotations;

namespace SampleBlazorApp.Data
{
    public class MyData
    {
        [Required]
        public string Name { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        public string Mail { get; set; }

        public MyData(string Name, string Password, string Mail)
        {
            this.Name = Name ?? "my name.";
            this.Password = Password ?? "";
            this.Mail = Mail ?? "";
        }

        public override string ToString()
        {
            return "[" + Name + "(" + Password + ")" + Mail + "]";
        }
    }
}

