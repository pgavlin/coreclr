using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtimetypehandle_RuntimeTypeHandleEquals_RuntimeTypeHandleEquals_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtimetypehandle_RuntimeTypeHandleEquals_RuntimeTypeHandleEquals_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtimetypehandle\\RuntimeTypeHandleEquals\\RuntimeTypeHandleEquals.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
