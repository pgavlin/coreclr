using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _JTrueNeDbl_JTrueNeDbl_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueNeDbl_JTrueNeDbl_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueNeDbl\\JTrueNeDbl.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
