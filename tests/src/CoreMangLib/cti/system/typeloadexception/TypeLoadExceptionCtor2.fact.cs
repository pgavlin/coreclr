using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_typeloadexception_TypeLoadExceptionCtor2_TypeLoadExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_typeloadexception_TypeLoadExceptionCtor2_TypeLoadExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\typeloadexception\\TypeLoadExceptionCtor2\\TypeLoadExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
