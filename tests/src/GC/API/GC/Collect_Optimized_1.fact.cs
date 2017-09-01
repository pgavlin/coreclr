using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_Collect_Optimized_1_Collect_Optimized_1_
    {
        [OuterLoop]
        [Fact]
        public void _GC_Collect_Optimized_1_Collect_Optimized_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_Optimized_1\\Collect_Optimized_1.cmd");
        }
    }
}
