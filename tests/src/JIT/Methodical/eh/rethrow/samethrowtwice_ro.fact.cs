using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_samethrowtwice_ro_samethrowtwice_ro_
    {
        [Fact]
        public void _eh_rethrow_samethrowtwice_ro_samethrowtwice_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\samethrowtwice_ro\\samethrowtwice_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
