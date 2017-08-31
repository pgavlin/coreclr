using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _InitObj_InitObj_
    {
        [OuterLoop]
        [Fact]
        public void _InitObj_InitObj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\InitObj\\InitObj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
