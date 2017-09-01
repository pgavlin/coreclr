using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Ind1_Ind1_
    {
        [OuterLoop]
        [Fact]
        public void _Ind1_Ind1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Ind1\\Ind1.cmd");
        }
    }
}
