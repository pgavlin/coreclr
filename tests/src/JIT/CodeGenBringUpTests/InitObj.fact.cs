using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _InitObj_InitObj_
    {
        [OuterLoop]
        [Fact]
        public void _InitObj_InitObj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\InitObj\\InitObj.cmd");
        }
    }
}
