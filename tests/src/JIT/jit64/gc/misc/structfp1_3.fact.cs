using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structfp1_3_structfp1_3_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfp1_3_structfp1_3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfp1_3\\structfp1_3.cmd");
        }
    }
}
