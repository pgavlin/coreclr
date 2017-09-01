using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPSmall_FPSmall_
    {
        [OuterLoop]
        [Fact]
        public void _FPSmall_FPSmall_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPSmall\\FPSmall.cmd");
        }
    }
}
