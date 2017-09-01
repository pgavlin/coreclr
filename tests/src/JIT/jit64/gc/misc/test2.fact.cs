using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_test2_test2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_test2_test2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\test2\\test2.cmd");
        }
    }
}
