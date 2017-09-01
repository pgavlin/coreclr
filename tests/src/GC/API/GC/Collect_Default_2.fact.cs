using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_Collect_Default_2_Collect_Default_2_
    {
        [OuterLoop]
        [Fact]
        public void _GC_Collect_Default_2_Collect_Default_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_Default_2\\Collect_Default_2.cmd");
        }
    }
}
