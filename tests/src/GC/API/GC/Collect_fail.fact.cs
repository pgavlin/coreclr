using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_Collect_fail_Collect_fail_
    {
        [Fact]
        public void _GC_Collect_fail_Collect_fail_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_fail\\Collect_fail.cmd");
        }
    }
}
