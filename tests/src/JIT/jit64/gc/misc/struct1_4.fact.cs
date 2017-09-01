using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct1_4_struct1_4_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct1_4_struct1_4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct1_4\\struct1_4.cmd");
        }
    }
}
