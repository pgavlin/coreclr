using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_Collect_Forced_1_Collect_Forced_1_
    {
        [OuterLoop]
        [Fact]
        public void _GC_Collect_Forced_1_Collect_Forced_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_Forced_1\\Collect_Forced_1.cmd");
        }
    }
}
