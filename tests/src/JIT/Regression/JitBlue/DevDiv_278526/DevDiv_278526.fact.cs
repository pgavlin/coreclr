using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_278526_DevDiv_278526_DevDiv_278526_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_278526_DevDiv_278526_DevDiv_278526_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_278526\\DevDiv_278526\\DevDiv_278526.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
