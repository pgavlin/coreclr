using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structva1_1_structva1_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structva1_1_structva1_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structva1_1\\structva1_1.cmd");
        }
    }
}
