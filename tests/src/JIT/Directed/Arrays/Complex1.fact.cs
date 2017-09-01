using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _Arrays_Complex1_Complex1_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_Complex1_Complex1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\Arrays\\Complex1\\Complex1.cmd");
        }
    }
}
