using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct2_struct2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct2_struct2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct2\\struct2.cmd");
        }
    }
}
