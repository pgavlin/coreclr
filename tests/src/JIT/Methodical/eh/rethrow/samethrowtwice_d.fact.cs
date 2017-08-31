using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_samethrowtwice_d_samethrowtwice_d_
    {
        [Fact]
        public void _eh_rethrow_samethrowtwice_d_samethrowtwice_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\samethrowtwice_d\\samethrowtwice_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
