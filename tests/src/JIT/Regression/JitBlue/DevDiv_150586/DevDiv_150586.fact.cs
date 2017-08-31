using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_150586_DevDiv_150586_DevDiv_150586_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_150586_DevDiv_150586_DevDiv_150586_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_150586\\DevDiv_150586\\DevDiv_150586.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
