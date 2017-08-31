using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtimemethodhandle_RuntimeMethodHandleEquals_RuntimeMethodHandleEquals_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtimemethodhandle_RuntimeMethodHandleEquals_RuntimeMethodHandleEquals_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtimemethodhandle\\RuntimeMethodHandleEquals\\RuntimeMethodHandleEquals.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
