using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_Collect_Forced_3_Collect_Forced_3_
    {
        [OuterLoop]
        [Fact]
        public void _GC_Collect_Forced_3_Collect_Forced_3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_Forced_3\\Collect_Forced_3.cmd");
        }
    }
}
