using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_samerethrowtwice_d_samerethrowtwice_d_
    {
        [Fact]
        public void _eh_rethrow_samerethrowtwice_d_samerethrowtwice_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\samerethrowtwice_d\\samerethrowtwice_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
