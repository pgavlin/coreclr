using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_samerethrowtwice_ro_samerethrowtwice_ro_
    {
        [Fact]
        public void _eh_rethrow_samerethrowtwice_ro_samerethrowtwice_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\samerethrowtwice_ro\\samerethrowtwice_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
