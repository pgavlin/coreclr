using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_279396_DevDiv_279396_DevDiv_279396_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_279396_DevDiv_279396_DevDiv_279396_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_279396\\DevDiv_279396\\DevDiv_279396.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
