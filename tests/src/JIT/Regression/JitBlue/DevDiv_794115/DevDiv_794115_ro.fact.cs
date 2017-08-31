using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_794115_DevDiv_794115_ro_DevDiv_794115_ro_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_794115_DevDiv_794115_ro_DevDiv_794115_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_794115\\DevDiv_794115_ro\\DevDiv_794115_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
