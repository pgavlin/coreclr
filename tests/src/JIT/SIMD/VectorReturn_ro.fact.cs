using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorReturn_ro_VectorReturn_ro_
    {
        [Fact]
        public void _VectorReturn_ro_VectorReturn_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorReturn_ro\\VectorReturn_ro.cmd");
        }
    }
}
