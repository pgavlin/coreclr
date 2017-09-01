using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_Collect_Default_1_Collect_Default_1_
    {
        [OuterLoop]
        [Fact]
        public void _GC_Collect_Default_1_Collect_Default_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_Default_1\\Collect_Default_1.cmd");
        }
    }
}
