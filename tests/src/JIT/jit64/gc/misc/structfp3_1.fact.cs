using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structfp3_1_structfp3_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfp3_1_structfp3_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfp3_1\\structfp3_1.cmd");
        }
    }
}
