using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_interactions_ehso_ehso_
    {
        [OuterLoop]
        [Fact]
        public void _eh_interactions_ehso_ehso_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\ehso\\ehso.cmd");
        }
    }
}
