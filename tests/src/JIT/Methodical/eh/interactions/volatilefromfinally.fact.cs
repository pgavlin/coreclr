using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_interactions_volatilefromfinally_volatilefromfinally_
    {
        [OuterLoop]
        [Fact]
        public void _eh_interactions_volatilefromfinally_volatilefromfinally_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\volatilefromfinally\\volatilefromfinally.cmd");
        }
    }
}
