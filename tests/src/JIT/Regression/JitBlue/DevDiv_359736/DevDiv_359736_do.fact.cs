using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_359736_DevDiv_359736_do_DevDiv_359736_do_
    {
        [Fact]
        public void _JitBlue_DevDiv_359736_DevDiv_359736_do_DevDiv_359736_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_359736\\DevDiv_359736_do\\DevDiv_359736_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
