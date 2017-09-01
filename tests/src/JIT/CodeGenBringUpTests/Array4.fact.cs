using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Array4_Array4_
    {
        [OuterLoop]
        [Fact]
        public void _Array4_Array4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Array4\\Array4.cmd");
        }
    }
}
