using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structret2_2_structret2_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret2_2_structret2_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret2_2\\structret2_2.cmd");
        }
    }
}
