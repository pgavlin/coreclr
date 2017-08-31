using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_10621_GitHub_10621_GitHub_10621_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_10621_GitHub_10621_GitHub_10621_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_10621\\GitHub_10621\\GitHub_10621.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
