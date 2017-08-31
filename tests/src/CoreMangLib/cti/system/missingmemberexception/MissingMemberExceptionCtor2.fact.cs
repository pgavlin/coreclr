using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_missingmemberexception_MissingMemberExceptionCtor2_MissingMemberExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_missingmemberexception_MissingMemberExceptionCtor2_MissingMemberExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\missingmemberexception\\MissingMemberExceptionCtor2\\MissingMemberExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
