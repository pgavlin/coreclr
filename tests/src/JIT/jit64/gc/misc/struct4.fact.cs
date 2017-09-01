using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct4_struct4_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct4_struct4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct4\\struct4.cmd");
        }
    }
}
