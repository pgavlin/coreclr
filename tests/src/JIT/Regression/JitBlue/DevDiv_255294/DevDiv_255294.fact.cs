using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _JitBlue_DevDiv_255294_DevDiv_255294_DevDiv_255294_
    {
        [ActiveIssue("11469, The test causes OutOfMemory exception in crossgen mode.")]//, TestArchitectures.X86)]
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_255294_DevDiv_255294_DevDiv_255294_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_255294\\DevDiv_255294\\DevDiv_255294.cmd");
        }
    }
}
