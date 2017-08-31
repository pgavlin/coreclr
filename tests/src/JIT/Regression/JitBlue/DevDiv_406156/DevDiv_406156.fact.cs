using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_406156_DevDiv_406156_DevDiv_406156_
    {
        [Fact]
        public void _JitBlue_DevDiv_406156_DevDiv_406156_DevDiv_406156_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_406156\\DevDiv_406156\\DevDiv_406156.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
