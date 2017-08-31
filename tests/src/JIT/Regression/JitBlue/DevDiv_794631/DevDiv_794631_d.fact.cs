using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_794631_DevDiv_794631_d_DevDiv_794631_d_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_794631_DevDiv_794631_d_DevDiv_794631_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_794631\\DevDiv_794631_d\\DevDiv_794631_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
