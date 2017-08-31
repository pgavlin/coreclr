using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _ArrayMD1_ArrayMD1_
    {
        [OuterLoop]
        [Fact]
        public void _ArrayMD1_ArrayMD1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\ArrayMD1\\ArrayMD1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
