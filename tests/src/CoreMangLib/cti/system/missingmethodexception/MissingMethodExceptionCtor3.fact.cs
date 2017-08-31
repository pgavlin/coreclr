using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_missingmethodexception_MissingMethodExceptionCtor3_MissingMethodExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_missingmethodexception_MissingMethodExceptionCtor3_MissingMethodExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\missingmethodexception\\MissingMethodExceptionCtor3\\MissingMethodExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
