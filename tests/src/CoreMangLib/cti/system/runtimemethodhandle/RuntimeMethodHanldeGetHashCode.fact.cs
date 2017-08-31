using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtimemethodhandle_RuntimeMethodHanldeGetHashCode_RuntimeMethodHanldeGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtimemethodhandle_RuntimeMethodHanldeGetHashCode_RuntimeMethodHanldeGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtimemethodhandle\\RuntimeMethodHanldeGetHashCode\\RuntimeMethodHanldeGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
