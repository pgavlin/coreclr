using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_Collect_Forced_2_Collect_Forced_2_
    {
        [OuterLoop]
        [Fact]
        public void _GC_Collect_Forced_2_Collect_Forced_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_Forced_2\\Collect_Forced_2.cmd");
        }
    }
}
