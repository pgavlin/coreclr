using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _ArrayObj_ArrayObj_
    {
        [OuterLoop]
        [Fact]
        public void _ArrayObj_ArrayObj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\ArrayObj\\ArrayObj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
