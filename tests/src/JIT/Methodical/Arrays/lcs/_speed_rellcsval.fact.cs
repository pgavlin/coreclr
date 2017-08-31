using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__speed_rellcsval__speed_rellcsval_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_lcs__speed_rellcsval__speed_rellcsval_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_speed_rellcsval\\_speed_rellcsval.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
