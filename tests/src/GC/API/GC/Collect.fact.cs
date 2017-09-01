using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_Collect_Collect_
    {
        [OuterLoop]
        [Fact]
        public void _GC_Collect_Collect_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\Collect\\Collect.cmd");
        }
    }
}
