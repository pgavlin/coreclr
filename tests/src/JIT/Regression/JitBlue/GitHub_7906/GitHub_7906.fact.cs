using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_7906_GitHub_7906_GitHub_7906_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_7906_GitHub_7906_GitHub_7906_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_7906\\GitHub_7906\\GitHub_7906.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
