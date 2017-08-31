using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_255294_DevDiv_255294_DevDiv_255294_
    {
        [ActiveIssue("11469, The test causes OutOfMemory exception in crossgen mode.")]//, TestArchitectures.X86)]
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_255294_DevDiv_255294_DevDiv_255294_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_255294\\DevDiv_255294\\DevDiv_255294.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
