using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _IL_rethrow_Rethrow1_Rethrow1_
    {
        [Fact]
        public void _IL_rethrow_Rethrow1_Rethrow1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\IL\\rethrow\\Rethrow1\\Rethrow1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
