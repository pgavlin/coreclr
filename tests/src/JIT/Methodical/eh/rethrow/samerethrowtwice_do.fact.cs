using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_samerethrowtwice_do_samerethrowtwice_do_
    {
        [Fact]
        public void _eh_rethrow_samerethrowtwice_do_samerethrowtwice_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\samerethrowtwice_do\\samerethrowtwice_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
