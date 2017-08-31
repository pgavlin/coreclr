using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_waithandle_WaitHandleDispose1_WaitHandleDispose1_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_waithandle_WaitHandleDispose1_WaitHandleDispose1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\waithandle\\WaitHandleDispose1\\WaitHandleDispose1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
