using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_interactions_gcincatch_ro_gcincatch_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_interactions_gcincatch_ro_gcincatch_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\gcincatch_ro\\gcincatch_ro.cmd");
        }
    }
}
