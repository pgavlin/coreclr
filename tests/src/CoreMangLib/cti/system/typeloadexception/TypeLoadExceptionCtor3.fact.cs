using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_typeloadexception_TypeLoadExceptionCtor3_TypeLoadExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_typeloadexception_TypeLoadExceptionCtor3_TypeLoadExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\typeloadexception\\TypeLoadExceptionCtor3\\TypeLoadExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
