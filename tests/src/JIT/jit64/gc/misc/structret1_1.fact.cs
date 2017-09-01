using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structret1_1_structret1_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret1_1_structret1_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret1_1\\structret1_1.cmd");
        }
    }
}
