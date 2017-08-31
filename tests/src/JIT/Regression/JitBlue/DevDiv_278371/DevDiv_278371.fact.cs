using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_278371_DevDiv_278371_DevDiv_278371_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_278371_DevDiv_278371_DevDiv_278371_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_278371\\DevDiv_278371\\DevDiv_278371.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
