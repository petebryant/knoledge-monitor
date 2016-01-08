using System.Runtime.InteropServices;

namespace Knoledge_Monitor
{
    public static class NativeCalls
    {
        [DllImport("wininet.dll")]
        public extern static bool InternetGetConnectedState(out int description, int reservedValue);
    }
}
