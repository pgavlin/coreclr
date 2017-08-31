using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_288222_DevDiv_288222_DevDiv_288222_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_288222_DevDiv_288222_DevDiv_288222_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_288222\\DevDiv_288222\\DevDiv_288222.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
