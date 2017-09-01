using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_timespan_TimeSpanFromTicks_TimeSpanFromTicks_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanFromTicks_TimeSpanFromTicks_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanFromTicks\\TimeSpanFromTicks.cmd");
        }
    }
}
