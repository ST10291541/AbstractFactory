namespace AbstractFactory
{
    public class WirelessEarbuds : IGadget
    {
        private string brand;
        private string model;
        
        public WirelessEarbuds(string brand, string model) 
        {
            this.brand = brand;
            this.model = model;
        }

        public string getDetails() 
        {
            return this.brand + " " + this.model +  " - WirelessEarbuds";
        }
    }
}

