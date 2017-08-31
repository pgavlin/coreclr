using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_13404_GitHub_13404_GitHub_13404_
    {
        [Fact]
        public void _JitBlue_GitHub_13404_GitHub_13404_GitHub_13404_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_13404\\GitHub_13404\\GitHub_13404.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
