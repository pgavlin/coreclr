using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_278369_DevDiv_278369_DevDiv_278369_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_278369_DevDiv_278369_DevDiv_278369_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_278369\\DevDiv_278369\\DevDiv_278369.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
