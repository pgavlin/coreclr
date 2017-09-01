using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Array3_Array3_
    {
        [OuterLoop]
        [Fact]
        public void _Array3_Array3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Array3\\Array3.cmd");
        }
    }
}
