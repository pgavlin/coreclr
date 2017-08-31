using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _throwbox_finally_finally_
    {
        [Fact]
        public void _throwbox_finally_finally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\throwbox\\finally\\finally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
