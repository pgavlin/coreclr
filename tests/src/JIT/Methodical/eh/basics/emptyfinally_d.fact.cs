using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_emptyfinally_d_emptyfinally_d_
    {
        [Fact]
        public void _eh_basics_emptyfinally_d_emptyfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\emptyfinally_d\\emptyfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
