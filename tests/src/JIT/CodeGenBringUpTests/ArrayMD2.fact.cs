using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _ArrayMD2_ArrayMD2_
    {
        [OuterLoop]
        [Fact]
        public void _ArrayMD2_ArrayMD2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\ArrayMD2\\ArrayMD2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
