using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structfp2_4_structfp2_4_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfp2_4_structfp2_4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfp2_4\\structfp2_4.cmd");
        }
    }
}
