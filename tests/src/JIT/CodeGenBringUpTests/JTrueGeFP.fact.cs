using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _JTrueGeFP_JTrueGeFP_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueGeFP_JTrueGeFP_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueGeFP\\JTrueGeFP.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
