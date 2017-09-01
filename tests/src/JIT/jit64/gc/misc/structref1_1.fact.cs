using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structref1_1_structref1_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structref1_1_structref1_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structref1_1\\structref1_1.cmd");
        }
    }
}
