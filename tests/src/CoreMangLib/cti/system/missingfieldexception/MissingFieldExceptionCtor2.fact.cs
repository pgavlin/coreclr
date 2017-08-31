using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_missingfieldexception_MissingFieldExceptionCtor2_MissingFieldExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_missingfieldexception_MissingFieldExceptionCtor2_MissingFieldExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\missingfieldexception\\MissingFieldExceptionCtor2\\MissingFieldExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
