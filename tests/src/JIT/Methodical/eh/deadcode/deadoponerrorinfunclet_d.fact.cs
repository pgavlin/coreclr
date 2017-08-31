using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_deadoponerrorinfunclet_d_deadoponerrorinfunclet_d_
    {
        [Fact]
        public void _eh_deadcode_deadoponerrorinfunclet_d_deadoponerrorinfunclet_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadoponerrorinfunclet_d\\deadoponerrorinfunclet_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
