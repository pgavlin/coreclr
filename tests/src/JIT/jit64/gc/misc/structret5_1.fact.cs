using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structret5_1_structret5_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret5_1_structret5_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret5_1\\structret5_1.cmd");
        }
    }
}
