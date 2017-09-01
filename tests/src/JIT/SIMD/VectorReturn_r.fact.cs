using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorReturn_r_VectorReturn_r_
    {
        [Fact]
        public void _VectorReturn_r_VectorReturn_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorReturn_r\\VectorReturn_r.cmd");
        }
    }
}
