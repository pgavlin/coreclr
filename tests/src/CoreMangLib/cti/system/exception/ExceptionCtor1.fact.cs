using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_exception_ExceptionCtor1_ExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_exception_ExceptionCtor1_ExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\exception\\ExceptionCtor1\\ExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
