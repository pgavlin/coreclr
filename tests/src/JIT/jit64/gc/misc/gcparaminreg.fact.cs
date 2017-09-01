using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_gcparaminreg_gcparaminreg_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_gcparaminreg_gcparaminreg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\gcparaminreg\\gcparaminreg.cmd");
        }
    }
}
