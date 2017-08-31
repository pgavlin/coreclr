using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_strswitchfinal_do_strswitchfinal_do_
    {
        [Fact]
        public void _eh_interactions_strswitchfinal_do_strswitchfinal_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\strswitchfinal_do\\strswitchfinal_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
