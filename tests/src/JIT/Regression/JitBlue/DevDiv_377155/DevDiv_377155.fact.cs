using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_377155_DevDiv_377155_DevDiv_377155_
    {
        [Fact]
        public void _JitBlue_DevDiv_377155_DevDiv_377155_DevDiv_377155_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_377155\\DevDiv_377155\\DevDiv_377155.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
