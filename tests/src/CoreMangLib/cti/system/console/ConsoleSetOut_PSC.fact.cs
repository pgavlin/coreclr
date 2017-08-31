using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_console_ConsoleSetOut_PSC_ConsoleSetOut_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_console_ConsoleSetOut_PSC_ConsoleSetOut_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\console\\ConsoleSetOut_PSC\\ConsoleSetOut_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
