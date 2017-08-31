using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_deadEHregionacrossBB_r_deadEHregionacrossBB_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadEHregionacrossBB_r_deadEHregionacrossBB_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadEHregionacrossBB_r\\deadEHregionacrossBB_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
