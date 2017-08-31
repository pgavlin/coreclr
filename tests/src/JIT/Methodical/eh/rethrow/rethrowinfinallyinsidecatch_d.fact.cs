using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_rethrowinfinallyinsidecatch_d_rethrowinfinallyinsidecatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_rethrowinfinallyinsidecatch_d_rethrowinfinallyinsidecatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\rethrowinfinallyinsidecatch_d\\rethrowinfinallyinsidecatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
