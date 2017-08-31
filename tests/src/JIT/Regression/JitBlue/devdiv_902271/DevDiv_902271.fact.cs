using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_devdiv_902271_DevDiv_902271_DevDiv_902271_
    {
        [Fact]
        public void _JitBlue_devdiv_902271_DevDiv_902271_DevDiv_902271_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\devdiv_902271\\DevDiv_902271\\DevDiv_902271.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
