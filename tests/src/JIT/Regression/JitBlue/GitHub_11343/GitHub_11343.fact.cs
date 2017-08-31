using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_11343_GitHub_11343_GitHub_11343_
    {
        [Fact]
        public void _JitBlue_GitHub_11343_GitHub_11343_GitHub_11343_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_11343\\GitHub_11343\\GitHub_11343.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
