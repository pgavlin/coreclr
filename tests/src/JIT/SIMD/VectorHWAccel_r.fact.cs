using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorHWAccel_r_VectorHWAccel_r_
    {
        [Fact]
        public void _VectorHWAccel_r_VectorHWAccel_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorHWAccel_r\\VectorHWAccel_r.cmd");
        }
    }
}
