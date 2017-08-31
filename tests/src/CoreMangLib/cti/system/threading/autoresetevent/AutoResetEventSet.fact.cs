using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_autoresetevent_AutoResetEventSet_AutoResetEventSet_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_autoresetevent_AutoResetEventSet_AutoResetEventSet_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\autoresetevent\\AutoResetEventSet\\AutoResetEventSet.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
