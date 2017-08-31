using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_strswitchfinal_ro_strswitchfinal_ro_
    {
        [Fact]
        public void _eh_interactions_strswitchfinal_ro_strswitchfinal_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\strswitchfinal_ro\\strswitchfinal_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
