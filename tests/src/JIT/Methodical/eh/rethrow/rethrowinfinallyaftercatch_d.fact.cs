using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_rethrowinfinallyaftercatch_d_rethrowinfinallyaftercatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_rethrowinfinallyaftercatch_d_rethrowinfinallyaftercatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\rethrowinfinallyaftercatch_d\\rethrowinfinallyaftercatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
