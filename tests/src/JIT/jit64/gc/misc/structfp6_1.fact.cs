using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structfp6_1_structfp6_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfp6_1_structfp6_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfp6_1\\structfp6_1.cmd");
        }
    }
}
