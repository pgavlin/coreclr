using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_794115_DevDiv_794115_d_DevDiv_794115_d_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_794115_DevDiv_794115_d_DevDiv_794115_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_794115\\DevDiv_794115_d\\DevDiv_794115_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
