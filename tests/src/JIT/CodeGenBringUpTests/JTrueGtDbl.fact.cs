using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _JTrueGtDbl_JTrueGtDbl_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueGtDbl_JTrueGtDbl_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueGtDbl\\JTrueGtDbl.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
