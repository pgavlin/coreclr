using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_rethrowinfinallyaftercatch_r_rethrowinfinallyaftercatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_rethrowinfinallyaftercatch_r_rethrowinfinallyaftercatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\rethrowinfinallyaftercatch_r\\rethrowinfinallyaftercatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
