using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_waithandle_WaitHandleCtor_WaitHandleCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_waithandle_WaitHandleCtor_WaitHandleCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\waithandle\\WaitHandleCtor\\WaitHandleCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
