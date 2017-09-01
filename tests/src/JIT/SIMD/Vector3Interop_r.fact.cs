using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Vector3Interop_r_Vector3Interop_r_
    {
        [Fact]
        public void _Vector3Interop_r_Vector3Interop_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Vector3Interop_r\\Vector3Interop_r.cmd");
        }
    }
}
