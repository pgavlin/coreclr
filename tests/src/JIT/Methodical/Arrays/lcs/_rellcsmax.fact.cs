using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__rellcsmax__rellcsmax_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_lcs__rellcsmax__rellcsmax_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_rellcsmax\\_rellcsmax.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
