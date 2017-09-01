using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structfp1_1_structfp1_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfp1_1_structfp1_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfp1_1\\structfp1_1.cmd");
        }
    }
}
