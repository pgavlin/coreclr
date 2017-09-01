using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPFillArray_FPFillArray_
    {
        [OuterLoop]
        [Fact]
        public void _FPFillArray_FPFillArray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPFillArray\\FPFillArray.cmd");
        }
    }
}
