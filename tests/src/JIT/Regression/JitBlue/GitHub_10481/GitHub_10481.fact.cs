using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_10481_GitHub_10481_GitHub_10481_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_10481_GitHub_10481_GitHub_10481_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_10481\\GitHub_10481\\GitHub_10481.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
