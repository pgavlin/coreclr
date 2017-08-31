using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _DblMul_DblMul_
    {
        [OuterLoop]
        [Fact]
        public void _DblMul_DblMul_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblMul\\DblMul.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
