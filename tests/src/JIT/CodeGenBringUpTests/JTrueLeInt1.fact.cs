using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _JTrueLeInt1_JTrueLeInt1_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueLeInt1_JTrueLeInt1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueLeInt1\\JTrueLeInt1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
