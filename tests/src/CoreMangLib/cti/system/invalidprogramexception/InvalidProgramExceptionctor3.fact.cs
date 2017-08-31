using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_invalidprogramexception_InvalidProgramExceptionctor3_InvalidProgramExceptionctor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_invalidprogramexception_InvalidProgramExceptionctor3_InvalidProgramExceptionctor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\invalidprogramexception\\InvalidProgramExceptionctor3\\InvalidProgramExceptionctor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
