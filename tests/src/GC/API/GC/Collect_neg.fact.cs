using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_Collect_neg_Collect_neg_
    {
        [Fact]
        public void _GC_Collect_neg_Collect_neg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_neg\\Collect_neg.cmd");
        }
    }
}
