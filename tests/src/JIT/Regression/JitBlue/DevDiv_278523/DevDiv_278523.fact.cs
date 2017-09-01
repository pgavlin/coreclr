using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _JitBlue_DevDiv_278523_DevDiv_278523_DevDiv_278523_
    {
        [ActiveIssue("11476, fails on both jit32 and RyuJit x86")]//, TestArchitectures.X86)]
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_278523_DevDiv_278523_DevDiv_278523_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_278523\\DevDiv_278523\\DevDiv_278523.cmd");
        }
    }
}
