using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_samethrowtwice_r_samethrowtwice_r_
    {
        [Fact]
        public void _eh_rethrow_samethrowtwice_r_samethrowtwice_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\samethrowtwice_r\\samethrowtwice_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
