using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_359736_DevDiv_359736_d_DevDiv_359736_d_
    {
        [Fact]
        public void _JitBlue_DevDiv_359736_DevDiv_359736_d_DevDiv_359736_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_359736\\DevDiv_359736_d\\DevDiv_359736_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
