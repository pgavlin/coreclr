using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_794115_DevDiv_794115_do_DevDiv_794115_do_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_794115_DevDiv_794115_do_DevDiv_794115_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_794115\\DevDiv_794115_do\\DevDiv_794115_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
