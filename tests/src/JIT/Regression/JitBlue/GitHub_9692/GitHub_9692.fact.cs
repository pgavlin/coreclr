using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_9692_GitHub_9692_GitHub_9692_
    {
        [Fact]
        public void _JitBlue_GitHub_9692_GitHub_9692_GitHub_9692_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_9692\\GitHub_9692\\GitHub_9692.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
