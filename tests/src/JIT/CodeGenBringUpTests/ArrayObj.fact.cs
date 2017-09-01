using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _ArrayObj_ArrayObj_
    {
        [OuterLoop]
        [Fact]
        public void _ArrayObj_ArrayObj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\ArrayObj\\ArrayObj.cmd");
        }
    }
}
