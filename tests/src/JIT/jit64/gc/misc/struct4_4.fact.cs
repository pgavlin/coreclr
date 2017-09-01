using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct4_4_struct4_4_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct4_4_struct4_4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct4_4\\struct4_4.cmd");
        }
    }
}
