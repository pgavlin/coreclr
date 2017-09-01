using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Array1_Array1_
    {
        [OuterLoop]
        [Fact]
        public void _Array1_Array1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Array1\\Array1.cmd");
        }
    }
}
