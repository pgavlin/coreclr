using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_manualresetevent_ManualResetEventCtor_ManualResetEventCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_manualresetevent_ManualResetEventCtor_ManualResetEventCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\manualresetevent\\ManualResetEventCtor\\ManualResetEventCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
