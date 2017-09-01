using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Vector3Interop_ro_Vector3Interop_ro_
    {
        [Fact]
        public void _Vector3Interop_ro_Vector3Interop_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Vector3Interop_ro\\Vector3Interop_ro.cmd");
        }
    }
}
