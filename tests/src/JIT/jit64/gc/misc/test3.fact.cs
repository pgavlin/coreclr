using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_test3_test3_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_test3_test3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\test3\\test3.cmd");
        }
    }
}
