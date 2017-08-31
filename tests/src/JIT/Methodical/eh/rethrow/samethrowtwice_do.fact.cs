using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_samethrowtwice_do_samethrowtwice_do_
    {
        [Fact]
        public void _eh_rethrow_samethrowtwice_do_samethrowtwice_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\samethrowtwice_do\\samethrowtwice_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
