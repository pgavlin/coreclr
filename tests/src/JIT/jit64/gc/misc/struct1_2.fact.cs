using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct1_2_struct1_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct1_2_struct1_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct1_2\\struct1_2.cmd");
        }
    }
}
