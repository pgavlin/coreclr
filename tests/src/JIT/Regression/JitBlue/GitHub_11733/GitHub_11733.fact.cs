using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_11733_GitHub_11733_GitHub_11733_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_11733_GitHub_11733_GitHub_11733_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_11733\\GitHub_11733\\GitHub_11733.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
