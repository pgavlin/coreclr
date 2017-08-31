using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_278523_DevDiv_278523_DevDiv_278523_
    {
        [ActiveIssue("11476, fails on both jit32 and RyuJit x86")]//, TestArchitectures.X86)]
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_278523_DevDiv_278523_DevDiv_278523_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_278523\\DevDiv_278523\\DevDiv_278523.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
