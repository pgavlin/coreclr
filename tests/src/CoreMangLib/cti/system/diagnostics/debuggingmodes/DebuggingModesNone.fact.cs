using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_diagnostics_debuggingmodes_DebuggingModesNone_DebuggingModesNone_
    {
        [OuterLoop]
        [Fact]
        public void _system_diagnostics_debuggingmodes_DebuggingModesNone_DebuggingModesNone_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\diagnostics\\debuggingmodes\\DebuggingModesNone\\DebuggingModesNone.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
