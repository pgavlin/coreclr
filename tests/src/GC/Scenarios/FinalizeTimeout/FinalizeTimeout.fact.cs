using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _FinalizeTimeout_FinalizeTimeout_FinalizeTimeout_
    {
        [Fact]
        public void _FinalizeTimeout_FinalizeTimeout_FinalizeTimeout_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\FinalizeTimeout\\FinalizeTimeout\\FinalizeTimeout.cmd");
        }
    }
}
