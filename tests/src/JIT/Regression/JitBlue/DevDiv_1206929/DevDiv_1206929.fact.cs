using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_1206929_DevDiv_1206929_DevDiv_1206929_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_1206929_DevDiv_1206929_DevDiv_1206929_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_1206929\\DevDiv_1206929\\DevDiv_1206929.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
