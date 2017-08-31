using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _IL_rethrow_Rethrow2_Rethrow2_
    {
        [Fact]
        public void _IL_rethrow_Rethrow2_Rethrow2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\IL\\rethrow\\Rethrow2\\Rethrow2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
