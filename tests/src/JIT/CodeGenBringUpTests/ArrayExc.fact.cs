using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _ArrayExc_ArrayExc_
    {
        [Fact]
        public void _ArrayExc_ArrayExc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\ArrayExc\\ArrayExc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
