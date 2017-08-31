using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_deadEHregionacrossBB_d_deadEHregionacrossBB_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadEHregionacrossBB_d_deadEHregionacrossBB_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadEHregionacrossBB_d\\deadEHregionacrossBB_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
