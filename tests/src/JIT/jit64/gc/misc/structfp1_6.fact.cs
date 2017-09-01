using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structfp1_6_structfp1_6_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfp1_6_structfp1_6_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfp1_6\\structfp1_6.cmd");
        }
    }
}
