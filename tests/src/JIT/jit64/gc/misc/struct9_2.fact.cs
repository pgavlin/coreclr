using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct9_2_struct9_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct9_2_struct9_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct9_2\\struct9_2.cmd");
        }
    }
}
