using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_interactions_gcincatch_r_gcincatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_interactions_gcincatch_r_gcincatch_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\gcincatch_r\\gcincatch_r.cmd");
        }
    }
}
