using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_794631_DevDiv_794631_r_DevDiv_794631_r_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_794631_DevDiv_794631_r_DevDiv_794631_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_794631\\DevDiv_794631_r\\DevDiv_794631_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
