using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _JTrueLeFP_JTrueLeFP_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueLeFP_JTrueLeFP_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueLeFP\\JTrueLeFP.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
