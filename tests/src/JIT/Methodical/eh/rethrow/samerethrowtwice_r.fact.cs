using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_samerethrowtwice_r_samerethrowtwice_r_
    {
        [Fact]
        public void _eh_rethrow_samerethrowtwice_r_samerethrowtwice_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\samerethrowtwice_r\\samerethrowtwice_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
