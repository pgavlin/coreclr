using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structret3_3_structret3_3_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret3_3_structret3_3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret3_3\\structret3_3.cmd");
        }
    }
}
