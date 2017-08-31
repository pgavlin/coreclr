using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_406158_DevDiv_406158_DevDiv_406158_
    {
        [Fact]
        public void _JitBlue_DevDiv_406158_DevDiv_406158_DevDiv_406158_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_406158\\DevDiv_406158\\DevDiv_406158.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
