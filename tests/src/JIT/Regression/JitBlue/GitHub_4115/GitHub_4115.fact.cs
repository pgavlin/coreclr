using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_4115_GitHub_4115_GitHub_4115_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_4115_GitHub_4115_GitHub_4115_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_4115\\GitHub_4115\\GitHub_4115.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
