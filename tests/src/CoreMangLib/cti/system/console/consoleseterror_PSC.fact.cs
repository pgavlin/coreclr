using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_console_consoleseterror_PSC_consoleseterror_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_console_consoleseterror_PSC_consoleseterror_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\console\\consoleseterror_PSC\\consoleseterror_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
