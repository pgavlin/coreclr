using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_invalidprogramexception_InvalidProgramExceptionctor2_InvalidProgramExceptionctor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_invalidprogramexception_InvalidProgramExceptionctor2_InvalidProgramExceptionctor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\invalidprogramexception\\InvalidProgramExceptionctor2\\InvalidProgramExceptionctor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
