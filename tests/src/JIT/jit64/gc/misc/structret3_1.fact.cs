using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structret3_1_structret3_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret3_1_structret3_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret3_1\\structret3_1.cmd");
        }
    }
}
