using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_359736_DevDiv_359736_r_DevDiv_359736_r_
    {
        [Fact]
        public void _JitBlue_DevDiv_359736_DevDiv_359736_r_DevDiv_359736_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_359736\\DevDiv_359736_r\\DevDiv_359736_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
