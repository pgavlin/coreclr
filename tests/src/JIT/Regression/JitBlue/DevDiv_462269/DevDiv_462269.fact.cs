using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_462269_DevDiv_462269_DevDiv_462269_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_462269_DevDiv_462269_DevDiv_462269_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_462269\\DevDiv_462269\\DevDiv_462269.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
