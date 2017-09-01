using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPArray_FPArray_
    {
        [OuterLoop]
        [Fact]
        public void _FPArray_FPArray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPArray\\FPArray.cmd");
        }
    }
}
