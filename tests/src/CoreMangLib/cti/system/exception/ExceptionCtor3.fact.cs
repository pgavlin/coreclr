using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_exception_ExceptionCtor3_ExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_exception_ExceptionCtor3_ExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\exception\\ExceptionCtor3\\ExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
