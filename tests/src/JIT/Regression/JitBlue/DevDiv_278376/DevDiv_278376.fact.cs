using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_278376_DevDiv_278376_DevDiv_278376_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_278376_DevDiv_278376_DevDiv_278376_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_278376\\DevDiv_278376\\DevDiv_278376.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
