using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structfp1_5_structfp1_5_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structfp1_5_structfp1_5_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structfp1_5\\structfp1_5.cmd");
        }
    }
}
