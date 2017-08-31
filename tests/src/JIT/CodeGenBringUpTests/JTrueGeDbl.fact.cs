using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _JTrueGeDbl_JTrueGeDbl_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueGeDbl_JTrueGeDbl_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueGeDbl\\JTrueGeDbl.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
