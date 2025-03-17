using System.Runtime.InteropServices;

namespace Nvidia.Nvml
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NvmlUtilization
    {
        public uint gpu { get; }
        public uint memory { get; }
    }
}