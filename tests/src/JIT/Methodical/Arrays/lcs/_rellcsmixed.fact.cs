using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__rellcsmixed__rellcsmixed_
    {
        [Fact]
        public void _Arrays_lcs__rellcsmixed__rellcsmixed_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_rellcsmixed\\_rellcsmixed.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
