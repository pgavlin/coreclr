using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_exception_ExceptionCtor2_ExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_exception_ExceptionCtor2_ExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\exception\\ExceptionCtor2\\ExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
