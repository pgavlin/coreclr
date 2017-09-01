using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct3_2_struct3_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct3_2_struct3_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct3_2\\struct3_2.cmd");
        }
    }
}
