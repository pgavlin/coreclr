using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_278375_DevDiv_278375_DevDiv_278375_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_278375_DevDiv_278375_DevDiv_278375_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_278375\\DevDiv_278375\\DevDiv_278375.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
