namespace AbstractFactory 
{
    public class AppleFactory : IGadgetFactory
    {
        public Smartwatch CreateSmartWatch()
        {
            return new Smartwatch("Apple", "Watch 10");
        }

        public VRHeadset CreateVRHeadset()
        {
            return new VRHeadset("Apple", "Vision Pro");
        }

        public WirelessEarbuds CreateWirelessEarbuds()
        {
            return new WirelessEarbuds("Apple", "Airpods");
        }
    }
}