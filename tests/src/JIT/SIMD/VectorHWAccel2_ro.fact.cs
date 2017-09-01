using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorHWAccel2_ro_VectorHWAccel2_ro_
    {
        [Fact]
        public void _VectorHWAccel2_ro_VectorHWAccel2_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorHWAccel2_ro\\VectorHWAccel2_ro.cmd");
        }
    }
}
