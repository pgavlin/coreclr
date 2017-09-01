using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _Arrays_Simple2_Simple2_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_Simple2_Simple2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\Arrays\\Simple2\\Simple2.cmd");
        }
    }
}
