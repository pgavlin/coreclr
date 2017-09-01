using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_interactions_gcincatch_do_gcincatch_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_interactions_gcincatch_do_gcincatch_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\gcincatch_do\\gcincatch_do.cmd");
        }
    }
}
