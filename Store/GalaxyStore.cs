namespace AbstractFactory
{
    public class GalaxayStore
    {
        private IGadgetFactory _gadgetFactory;

        public GalaxayStore(IGadgetFactory factory)
        {
            _gadgetFactory = factory;
        }

        public void DisplayGadgets() 
        {
            var smartwatch = _gadgetFactory.CreateSmartWatch();
            var vrHeadset = _gadgetFactory.CreateVRHeadset();
            var wirelessEarbuds = _gadgetFactory.CreateWirelessEarbuds();

            Console.WriteLine(smartwatch.getDetails());
            Console.WriteLine(vrHeadset.getDetails());
            Console.WriteLine(wirelessEarbuds.getDetails());

            //Console.WriteLine(gadgetFactory.CreateSmartWatch.getDetails());
            //Console.WriteLine(gadgetFactory.CreateVRHeadset.GetDetails());
            //Console.WriteLine(gadgetFactory.CreateWirelessEarbuds.GetDetails());
        }
    }
}
