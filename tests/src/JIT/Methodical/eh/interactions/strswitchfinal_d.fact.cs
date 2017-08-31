using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_strswitchfinal_d_strswitchfinal_d_
    {
        [Fact]
        public void _eh_interactions_strswitchfinal_d_strswitchfinal_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\strswitchfinal_d\\strswitchfinal_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
