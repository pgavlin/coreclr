using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblFillArray_DblFillArray_
    {
        [OuterLoop]
        [Fact]
        public void _DblFillArray_DblFillArray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblFillArray\\DblFillArray.cmd");
        }
    }
}
