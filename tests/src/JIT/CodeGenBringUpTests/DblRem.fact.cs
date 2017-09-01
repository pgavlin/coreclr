using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblRem_DblRem_
    {
        [OuterLoop]
        [Fact]
        public void _DblRem_DblRem_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblRem\\DblRem.cmd");
        }
    }
}
