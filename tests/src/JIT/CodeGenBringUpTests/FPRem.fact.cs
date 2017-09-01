using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPRem_FPRem_
    {
        [OuterLoop]
        [Fact]
        public void _FPRem_FPRem_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPRem\\FPRem.cmd");
        }
    }
}
