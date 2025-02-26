

namespace AbstractFactory
{
    public class GalaxayStore
    {
        private IGadgetFactory gadgetFactory;

        public GalaxayStore(IGadgetFactory factory)
        {
            gadgetFactory = factory;
        }

        public void DisplayGadgets() 
        {
            //var smartwatch = _gadgetFactory.CreateSmartwatch();
            //var vrHeadset = _gadgetFactory.CreateVRHeadset();
            //var wirelessEarbuds = _gadgetFactory.CreateWirelessEarbuds();

            //Console.WriteLine(smartwatch.GetDetails());
            //Console.WriteLine(vrHeadset.GetDetails());
            //Console.WriteLine(wirelessEarbuds.GetDetails());

            Console.WriteLine(gadgetFactory.CreateSmartwatch.GetDetails());
            Console.WriteLine(gadgetFactory.CreateVRHeadset.GetDetails());
            Console.WriteLine(gadgetFactory.CreateWirelessEarbuds.GetDetails());
        }
    }
}s
