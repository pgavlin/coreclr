using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_vbil_vbil_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_vbil_vbil_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\vbil\\vbil.cmd");
        }
    }
}
