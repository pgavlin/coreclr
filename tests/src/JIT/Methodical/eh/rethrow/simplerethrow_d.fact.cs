using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_simplerethrow_d_simplerethrow_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_simplerethrow_d_simplerethrow_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\simplerethrow_d\\simplerethrow_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
