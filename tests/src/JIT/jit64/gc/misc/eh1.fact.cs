using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_eh1_eh1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_eh1_eh1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\eh1\\eh1.cmd");
        }
    }
}
