#if UNITY_EDITOR || UNITY_IOS || UNITY_TVOS
using UnityEngine.InputSystem.iOS.LowLevel;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.iOS
{
#if UNITY_DISABLE_DEFAULT_INPUT_PLUGIN_INITIALIZATION
    public
#else
    internal
#endif
    static class iOSSupport
    {
        public static void Initialize()
        {
            InputSystem.RegisterLayout<iOSGameController>("iOSGameController",
                matches: new InputDeviceMatcher()
                    .WithInterface("iOS")
                    .WithDeviceClass("iOSGameController"));

            InputSystem.RegisterLayout<XboxOneGampadiOS>("XboxOneGampadiOS",
                matches: new InputDeviceMatcher()
                    .WithInterface("iOS")
                    .WithDeviceClass("iOSGameController")
                    .WithProduct("Xbox Wireless Controller"));

            InputSystem.RegisterLayout<DualShock4GampadiOS>("DualShock4GampadiOS",
                matches: new InputDeviceMatcher()
                    .WithInterface("iOS")
                    .WithDeviceClass("iOSGameController")
                    .WithProduct("DUALSHOCK 4 Wireless Controller"));

            InputSystem.RegisterLayoutMatcher("GravitySensor",
                new InputDeviceMatcher()
                    .WithInterface("iOS")
                    .WithDeviceClass("Gravity"));
            InputSystem.RegisterLayoutMatcher("AttitudeSensor",
                new InputDeviceMatcher()
                    .WithInterface("iOS")
                    .WithDeviceClass("Attitude"));
            InputSystem.RegisterLayoutMatcher("LinearAccelerationSensor",
                new InputDeviceMatcher()
                    .WithInterface("iOS")
                    .WithDeviceClass("LinearAcceleration"));

            InputSystem.RegisterLayout<iOSStepCounter>();
            if (iOSStepCounter.IsAvailable())
                InputSystem.AddDevice<iOSStepCounter>();
        }
    }
}
#endif // UNITY_EDITOR || UNITY_IOS || UNITY_TVOS
