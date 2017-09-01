using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structfp4_1_structfp4_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfp4_1_structfp4_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfp4_1\\structfp4_1.cmd");
        }
    }
}
