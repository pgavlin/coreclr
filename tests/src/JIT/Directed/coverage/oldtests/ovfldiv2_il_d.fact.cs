using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_ovfldiv2_il_d_ovfldiv2_il_d_
    {
        [Fact]
        public void _coverage_oldtests_ovfldiv2_il_d_ovfldiv2_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\ovfldiv2_il_d\\ovfldiv2_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
