using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_794631_DevDiv_794631_do_DevDiv_794631_do_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_794631_DevDiv_794631_do_DevDiv_794631_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_794631\\DevDiv_794631_do\\DevDiv_794631_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
