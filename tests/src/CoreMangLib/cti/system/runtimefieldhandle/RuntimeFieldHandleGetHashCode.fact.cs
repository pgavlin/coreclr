using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtimefieldhandle_RuntimeFieldHandleGetHashCode_RuntimeFieldHandleGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtimefieldhandle_RuntimeFieldHandleGetHashCode_RuntimeFieldHandleGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtimefieldhandle\\RuntimeFieldHandleGetHashCode\\RuntimeFieldHandleGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
