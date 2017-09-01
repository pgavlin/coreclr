using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct2_2_struct2_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct2_2_struct2_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct2_2\\struct2_2.cmd");
        }
    }
}
