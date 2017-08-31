using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _JTrueGeInt1_JTrueGeInt1_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueGeInt1_JTrueGeInt1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueGeInt1\\JTrueGeInt1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
