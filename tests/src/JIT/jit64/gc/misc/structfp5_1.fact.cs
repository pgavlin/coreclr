using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structfp5_1_structfp5_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfp5_1_structfp5_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfp5_1\\structfp5_1.cmd");
        }
    }
}
