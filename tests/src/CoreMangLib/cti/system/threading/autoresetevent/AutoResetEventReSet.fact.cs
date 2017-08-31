using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_autoresetevent_AutoResetEventReSet_AutoResetEventReSet_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_autoresetevent_AutoResetEventReSet_AutoResetEventReSet_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\autoresetevent\\AutoResetEventReSet\\AutoResetEventReSet.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
