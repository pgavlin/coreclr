using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct6_struct6_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct6_struct6_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct6\\struct6.cmd");
        }
    }
}
