namespace AbstractFactory
{
    public class VRHeadset : IGadget
    {
        private string brand;
        private string model;
        
        public VRHeadset(string brand, string model) 
        {
            this.brand = brand;
            this.model = model;
        }

        public string getDetails() 
        {
            return this.brand + " " + this.model +  " - VR Headset";
        }
    }
}
