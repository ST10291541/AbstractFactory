

namespace AbstractFactory
{
    public interface IGadgetFactory
    {
        Smartwatch CreateSmartWatch();
        VRHeadset CreateVRHeadset();
        WirelessEarbuds CreateWirelessEarbuds();
    }
}