using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_794115_DevDiv_794115_r_DevDiv_794115_r_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_794115_DevDiv_794115_r_DevDiv_794115_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_794115\\DevDiv_794115_r\\DevDiv_794115_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
