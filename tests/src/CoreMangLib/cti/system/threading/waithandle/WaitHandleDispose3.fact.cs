using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_waithandle_WaitHandleDispose3_WaitHandleDispose3_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_waithandle_WaitHandleDispose3_WaitHandleDispose3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\waithandle\\WaitHandleDispose3\\WaitHandleDispose3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
