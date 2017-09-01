using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorHWAccel_ro_VectorHWAccel_ro_
    {
        [Fact]
        public void _VectorHWAccel_ro_VectorHWAccel_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorHWAccel_ro\\VectorHWAccel_ro.cmd");
        }
    }
}
