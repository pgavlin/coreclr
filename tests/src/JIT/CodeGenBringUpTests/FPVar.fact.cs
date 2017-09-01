using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPVar_FPVar_
    {
        [OuterLoop]
        [Fact]
        public void _FPVar_FPVar_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPVar\\FPVar.cmd");
        }
    }
}
