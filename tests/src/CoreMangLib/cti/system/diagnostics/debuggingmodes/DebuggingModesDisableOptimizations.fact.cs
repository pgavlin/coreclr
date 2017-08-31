using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_diagnostics_debuggingmodes_DebuggingModesDisableOptimizations_DebuggingModesDisableOptimizations_
    {
        [OuterLoop]
        [Fact]
        public void _system_diagnostics_debuggingmodes_DebuggingModesDisableOptimizations_DebuggingModesDisableOptimizations_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\diagnostics\\debuggingmodes\\DebuggingModesDisableOptimizations\\DebuggingModesDisableOptimizations.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
