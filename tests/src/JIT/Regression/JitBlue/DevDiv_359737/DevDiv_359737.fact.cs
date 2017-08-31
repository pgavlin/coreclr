using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_359737_DevDiv_359737_DevDiv_359737_
    {
        [Fact]
        public void _JitBlue_DevDiv_359737_DevDiv_359737_DevDiv_359737_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_359737\\DevDiv_359737\\DevDiv_359737.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
