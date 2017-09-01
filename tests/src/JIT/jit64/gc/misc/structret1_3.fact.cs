using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structret1_3_structret1_3_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret1_3_structret1_3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret1_3\\structret1_3.cmd");
        }
    }
}
