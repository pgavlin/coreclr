using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__speed_dbglcsval__speed_dbglcsval_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_lcs__speed_dbglcsval__speed_dbglcsval_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_speed_dbglcsval\\_speed_dbglcsval.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
