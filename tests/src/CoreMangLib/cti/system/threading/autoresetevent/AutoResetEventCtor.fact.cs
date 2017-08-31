using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_autoresetevent_AutoResetEventCtor_AutoResetEventCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_autoresetevent_AutoResetEventCtor_AutoResetEventCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\autoresetevent\\AutoResetEventCtor\\AutoResetEventCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
