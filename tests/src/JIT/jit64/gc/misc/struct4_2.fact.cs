using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct4_2_struct4_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct4_2_struct4_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct4_2\\struct4_2.cmd");
        }
    }
}
