using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _JTrueLtDbl_JTrueLtDbl_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueLtDbl_JTrueLtDbl_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueLtDbl\\JTrueLtDbl.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
