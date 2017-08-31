using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _FPArray_FPArray_
    {
        [OuterLoop]
        [Fact]
        public void _FPArray_FPArray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPArray\\FPArray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
