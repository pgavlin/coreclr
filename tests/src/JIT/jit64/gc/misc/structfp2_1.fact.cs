using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structfp2_1_structfp2_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfp2_1_structfp2_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfp2_1\\structfp2_1.cmd");
        }
    }
}
