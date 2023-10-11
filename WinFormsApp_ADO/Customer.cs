namespace WinFormsApp_ADO
{
    internal class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string DOB { get; set; }

        public string gender { get; set; }

        public string Address { get; set; }
        public Customer()
        {
            
        }

        public Customer(string id, string name, string dOB, string gender, string address)
        {
            Id = id;
            Name = name;
            DOB = dOB;
            this.gender = gender;
            Address = address;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}