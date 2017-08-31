using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_diagnostics_debuggingmodes_DebuggingModesIgnoreSymbolStoreSequencePoints_DebuggingModesIgnoreSymbolStoreSequencePoints_
    {
        [OuterLoop]
        [Fact]
        public void _system_diagnostics_debuggingmodes_DebuggingModesIgnoreSymbolStoreSequencePoints_DebuggingModesIgnoreSymbolStoreSequencePoints_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\diagnostics\\debuggingmodes\\DebuggingModesIgnoreSymbolStoreSequencePoints\\DebuggingModesIgnoreSymbolStoreSequencePoints.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
