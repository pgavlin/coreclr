using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _Arrays_Simple1_Simple1_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_Simple1_Simple1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\Arrays\\Simple1\\Simple1.cmd");
        }
    }
}
