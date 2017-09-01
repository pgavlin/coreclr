using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Ge1_Ge1_
    {
        [OuterLoop]
        [Fact]
        public void _Ge1_Ge1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Ge1\\Ge1.cmd");
        }
    }
}
