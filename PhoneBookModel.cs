namespace Phone_Book_Application
{
    public class PhoneBookModel
    {
        public string Name {get; set;}
        public string PhoneNumber {get; set;}
        public string Address {get; set;}
        public string Counting {get; set;} = "";

        public PhoneBookModel(string name, string phonenumber, string address)
        {
            Name = name;
            PhoneNumber = phonenumber;
            Address = address;
        }

        public override string ToString()
        {
            return $"{Counting}.{Name}, {PhoneNumber}, {Address}";
        }
    }
}