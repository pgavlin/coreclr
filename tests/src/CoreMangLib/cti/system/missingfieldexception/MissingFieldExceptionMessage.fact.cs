using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_missingfieldexception_MissingFieldExceptionMessage_MissingFieldExceptionMessage_
    {
        [OuterLoop]
        [Fact]
        public void _system_missingfieldexception_MissingFieldExceptionMessage_MissingFieldExceptionMessage_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\missingfieldexception\\MissingFieldExceptionMessage\\MissingFieldExceptionMessage.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
