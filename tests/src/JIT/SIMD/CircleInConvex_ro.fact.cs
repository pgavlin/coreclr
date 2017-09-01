using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _CircleInConvex_ro_CircleInConvex_ro_
    {
        [Fact]
        public void _CircleInConvex_ro_CircleInConvex_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\CircleInConvex_ro\\CircleInConvex_ro.cmd");
        }
    }
}
