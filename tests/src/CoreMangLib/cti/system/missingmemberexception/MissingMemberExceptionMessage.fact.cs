using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_missingmemberexception_MissingMemberExceptionMessage_MissingMemberExceptionMessage_
    {
        [OuterLoop]
        [Fact]
        public void _system_missingmemberexception_MissingMemberExceptionMessage_MissingMemberExceptionMessage_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\missingmemberexception\\MissingMemberExceptionMessage\\MissingMemberExceptionMessage.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
