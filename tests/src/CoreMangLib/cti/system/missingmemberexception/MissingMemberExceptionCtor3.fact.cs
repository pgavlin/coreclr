using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_missingmemberexception_MissingMemberExceptionCtor3_MissingMemberExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_missingmemberexception_MissingMemberExceptionCtor3_MissingMemberExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\missingmemberexception\\MissingMemberExceptionCtor3\\MissingMemberExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
