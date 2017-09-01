using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Eq1_Eq1_
    {
        [OuterLoop]
        [Fact]
        public void _Eq1_Eq1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Eq1\\Eq1.cmd");
        }
    }
}
