using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _RanCollect_rancollect_rancollect_
    {
        [Fact]
        public void _RanCollect_rancollect_rancollect_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\RanCollect\\rancollect\\rancollect.cmd");
        }
    }
}
