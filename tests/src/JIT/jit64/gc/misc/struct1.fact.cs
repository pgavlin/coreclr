using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct1_struct1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct1_struct1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct1\\struct1.cmd");
        }
    }
}
