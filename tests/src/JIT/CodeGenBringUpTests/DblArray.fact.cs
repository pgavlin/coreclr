using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblArray_DblArray_
    {
        [OuterLoop]
        [Fact]
        public void _DblArray_DblArray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblArray\\DblArray.cmd");
        }
    }
}
