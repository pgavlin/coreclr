using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _JTrueGtInt1_JTrueGtInt1_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueGtInt1_JTrueGtInt1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueGtInt1\\JTrueGtInt1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
