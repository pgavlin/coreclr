using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_missingmethodexception_MissingMethodExceptionMessage_MissingMethodExceptionMessage_
    {
        [OuterLoop]
        [Fact]
        public void _system_missingmethodexception_MissingMethodExceptionMessage_MissingMethodExceptionMessage_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\missingmethodexception\\MissingMethodExceptionMessage\\MissingMethodExceptionMessage.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
