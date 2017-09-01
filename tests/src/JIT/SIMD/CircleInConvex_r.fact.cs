using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _CircleInConvex_r_CircleInConvex_r_
    {
        [Fact]
        public void _CircleInConvex_r_CircleInConvex_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\CircleInConvex_r\\CircleInConvex_r.cmd");
        }
    }
}
