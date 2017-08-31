using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_environment_EnvironmentNewLine_EnvironmentNewLine_
    {
        [OuterLoop]
        [Fact]
        public void _system_environment_EnvironmentNewLine_EnvironmentNewLine_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\environment\\EnvironmentNewLine\\EnvironmentNewLine.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
