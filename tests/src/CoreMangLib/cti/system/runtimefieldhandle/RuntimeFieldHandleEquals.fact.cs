using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtimefieldhandle_RuntimeFieldHandleEquals_RuntimeFieldHandleEquals_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtimefieldhandle_RuntimeFieldHandleEquals_RuntimeFieldHandleEquals_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtimefieldhandle\\RuntimeFieldHandleEquals\\RuntimeFieldHandleEquals.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
