using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_typeloadexception_TypeLoadExceptionMessage_TypeLoadExceptionMessage_
    {
        [OuterLoop]
        [Fact]
        public void _system_typeloadexception_TypeLoadExceptionMessage_TypeLoadExceptionMessage_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\typeloadexception\\TypeLoadExceptionMessage\\TypeLoadExceptionMessage.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
