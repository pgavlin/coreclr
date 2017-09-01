using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct8_struct8_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct8_struct8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct8\\struct8.cmd");
        }
    }
}
