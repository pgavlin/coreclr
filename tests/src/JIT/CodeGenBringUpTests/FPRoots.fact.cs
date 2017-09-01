using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPRoots_FPRoots_
    {
        [OuterLoop]
        [Fact]
        public void _FPRoots_FPRoots_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPRoots\\FPRoots.cmd");
        }
    }
}
