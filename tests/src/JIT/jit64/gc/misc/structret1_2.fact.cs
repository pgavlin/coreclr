using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structret1_2_structret1_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret1_2_structret1_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret1_2\\structret1_2.cmd");
        }
    }
}
