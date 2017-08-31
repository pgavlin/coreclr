using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_missingfieldexception_MissingFieldExceptionCtor1_MissingFieldExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_missingfieldexception_MissingFieldExceptionCtor1_MissingFieldExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\missingfieldexception\\MissingFieldExceptionCtor1\\MissingFieldExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
