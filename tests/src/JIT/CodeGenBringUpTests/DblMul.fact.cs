using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblMul_DblMul_
    {
        [OuterLoop]
        [Fact]
        public void _DblMul_DblMul_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblMul\\DblMul.cmd");
        }
    }
}
