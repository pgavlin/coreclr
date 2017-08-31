using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_volatilefromfinally_volatilefromfinally_
    {
        [OuterLoop]
        [Fact]
        public void _eh_interactions_volatilefromfinally_volatilefromfinally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\volatilefromfinally\\volatilefromfinally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
