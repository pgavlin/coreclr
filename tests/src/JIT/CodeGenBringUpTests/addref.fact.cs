using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _addref_addref_
    {
        [OuterLoop]
        [Fact]
        public void _addref_addref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\addref\\addref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
