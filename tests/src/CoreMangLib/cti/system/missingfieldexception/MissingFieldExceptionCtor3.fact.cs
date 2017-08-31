using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_missingfieldexception_MissingFieldExceptionCtor3_MissingFieldExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_missingfieldexception_MissingFieldExceptionCtor3_MissingFieldExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\missingfieldexception\\MissingFieldExceptionCtor3\\MissingFieldExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
