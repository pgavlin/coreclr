using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Array2_Array2_
    {
        [OuterLoop]
        [Fact]
        public void _Array2_Array2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Array2\\Array2.cmd");
        }
    }
}
