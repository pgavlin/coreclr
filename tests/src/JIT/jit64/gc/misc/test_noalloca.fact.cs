using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_test_noalloca_test_noalloca_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_test_noalloca_test_noalloca_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\test_noalloca\\test_noalloca.cmd");
        }
    }
}
