using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct1_5_struct1_5_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct1_5_struct1_5_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct1_5\\struct1_5.cmd");
        }
    }
}
