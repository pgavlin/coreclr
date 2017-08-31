using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_359736_DevDiv_359736_ro_DevDiv_359736_ro_
    {
        [Fact]
        public void _JitBlue_DevDiv_359736_DevDiv_359736_ro_DevDiv_359736_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_359736\\DevDiv_359736_ro\\DevDiv_359736_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
