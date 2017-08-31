using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_10714_GitHub_10714_GitHub_10714_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_10714_GitHub_10714_GitHub_10714_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_10714\\GitHub_10714\\GitHub_10714.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
