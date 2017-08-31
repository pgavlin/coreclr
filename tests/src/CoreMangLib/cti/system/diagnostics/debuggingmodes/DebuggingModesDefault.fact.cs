using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_diagnostics_debuggingmodes_DebuggingModesDefault_DebuggingModesDefault_
    {
        [OuterLoop]
        [Fact]
        public void _system_diagnostics_debuggingmodes_DebuggingModesDefault_DebuggingModesDefault_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\diagnostics\\debuggingmodes\\DebuggingModesDefault\\DebuggingModesDefault.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
