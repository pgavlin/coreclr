using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_invalidprogramexception_InvalidProgramExceptionctor1_InvalidProgramExceptionctor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_invalidprogramexception_InvalidProgramExceptionctor1_InvalidProgramExceptionctor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\invalidprogramexception\\InvalidProgramExceptionctor1\\InvalidProgramExceptionctor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
