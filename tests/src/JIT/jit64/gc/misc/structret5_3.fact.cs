using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structret5_3_structret5_3_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret5_3_structret5_3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret5_3\\structret5_3.cmd");
        }
    }
}
