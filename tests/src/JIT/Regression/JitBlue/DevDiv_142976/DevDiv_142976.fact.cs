using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_142976_DevDiv_142976_DevDiv_142976_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_142976_DevDiv_142976_DevDiv_142976_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_142976\\DevDiv_142976\\DevDiv_142976.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
