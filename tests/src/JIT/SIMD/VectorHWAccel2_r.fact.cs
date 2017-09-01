using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorHWAccel2_r_VectorHWAccel2_r_
    {
        [Fact]
        public void _VectorHWAccel2_r_VectorHWAccel2_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorHWAccel2_r\\VectorHWAccel2_r.cmd");
        }
    }
}
