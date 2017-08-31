using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__il_dbglcs_ldlen__il_dbglcs_ldlen_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_lcs__il_dbglcs_ldlen__il_dbglcs_ldlen_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_il_dbglcs_ldlen\\_il_dbglcs_ldlen.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
