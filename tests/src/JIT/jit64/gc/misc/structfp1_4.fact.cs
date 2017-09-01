using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structfp1_4_structfp1_4_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfp1_4_structfp1_4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfp1_4\\structfp1_4.cmd");
        }
    }
}
