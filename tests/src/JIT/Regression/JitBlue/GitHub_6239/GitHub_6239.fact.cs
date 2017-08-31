using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_6239_GitHub_6239_GitHub_6239_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_6239_GitHub_6239_GitHub_6239_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_6239\\GitHub_6239\\GitHub_6239.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
