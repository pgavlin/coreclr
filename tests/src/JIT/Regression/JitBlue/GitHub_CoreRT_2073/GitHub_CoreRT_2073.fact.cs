using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_CoreRT_2073_GitHub_CoreRT_2073_GitHub_CoreRT_2073_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_CoreRT_2073_GitHub_CoreRT_2073_GitHub_CoreRT_2073_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_CoreRT_2073\\GitHub_CoreRT_2073\\GitHub_CoreRT_2073.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
