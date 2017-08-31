using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _NotAndNeg_NotAndNeg_
    {
        [OuterLoop]
        [Fact]
        public void _NotAndNeg_NotAndNeg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\NotAndNeg\\NotAndNeg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
