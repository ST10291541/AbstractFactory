namespace AbstractFactory
{
    public class Smartwatch : IGadget
    {
        private string brand;
        private string model;
        
        public Smartwatch(string brand, string model) 
        {
            this.brand = brand;
            this.model = model;
        }

        public string getDetails() 
        {
            return this.brand + " " + this.model +  " - Smartwatch";
        }
    }
}


