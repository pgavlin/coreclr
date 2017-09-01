using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_Collect_Default_3_Collect_Default_3_
    {
        [OuterLoop]
        [Fact]
        public void _GC_Collect_Default_3_Collect_Default_3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_Default_3\\Collect_Default_3.cmd");
        }
    }
}
