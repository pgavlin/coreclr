using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_interactions_gcincatch_d_gcincatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_interactions_gcincatch_d_gcincatch_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\gcincatch_d\\gcincatch_d.cmd");
        }
    }
}
