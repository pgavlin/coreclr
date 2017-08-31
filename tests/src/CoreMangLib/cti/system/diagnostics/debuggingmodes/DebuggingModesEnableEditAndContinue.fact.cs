using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_diagnostics_debuggingmodes_DebuggingModesEnableEditAndContinue_DebuggingModesEnableEditAndContinue_
    {
        [OuterLoop]
        [Fact]
        public void _system_diagnostics_debuggingmodes_DebuggingModesEnableEditAndContinue_DebuggingModesEnableEditAndContinue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\diagnostics\\debuggingmodes\\DebuggingModesEnableEditAndContinue\\DebuggingModesEnableEditAndContinue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
