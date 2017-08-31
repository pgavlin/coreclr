using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_missingmemberexception_MissingMemberExceptionCtor1_MissingMemberExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_missingmemberexception_MissingMemberExceptionCtor1_MissingMemberExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\missingmemberexception\\MissingMemberExceptionCtor1\\MissingMemberExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
