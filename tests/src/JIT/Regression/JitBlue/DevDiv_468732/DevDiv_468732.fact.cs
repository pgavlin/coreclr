using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_468732_DevDiv_468732_DevDiv_468732_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_468732_DevDiv_468732_DevDiv_468732_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_468732\\DevDiv_468732\\DevDiv_468732.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
