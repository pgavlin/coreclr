using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structfp1_2_structfp1_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfp1_2_structfp1_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfp1_2\\structfp1_2.cmd");
        }
    }
}
