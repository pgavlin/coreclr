using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _throwbox_rethrow_rethrow_
    {
        [Fact]
        public void _throwbox_rethrow_rethrow_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\throwbox\\rethrow\\rethrow.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
