using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_typeloadexception_TypeLoadExceptionCtor1_TypeLoadExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_typeloadexception_TypeLoadExceptionCtor1_TypeLoadExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\typeloadexception\\TypeLoadExceptionCtor1\\TypeLoadExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
