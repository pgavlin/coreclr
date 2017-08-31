using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_359733_DevDiv_359733_DevDiv_359733_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_359733_DevDiv_359733_DevDiv_359733_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_359733\\DevDiv_359733\\DevDiv_359733.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
