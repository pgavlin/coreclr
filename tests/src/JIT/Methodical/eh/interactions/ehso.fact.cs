using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_ehso_ehso_
    {
        [OuterLoop]
        [Fact]
        public void _eh_interactions_ehso_ehso_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\ehso\\ehso.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
