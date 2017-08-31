using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtimetypehandle_RuntimeTypeHandleGetHashCode_RuntimeTypeHandleGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtimetypehandle_RuntimeTypeHandleGetHashCode_RuntimeTypeHandleGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtimetypehandle\\RuntimeTypeHandleGetHashCode\\RuntimeTypeHandleGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
