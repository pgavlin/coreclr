using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_missingmethodexception_MissingMethodExceptionCtor1_MissingMethodExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_missingmethodexception_MissingMethodExceptionCtor1_MissingMethodExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\missingmethodexception\\MissingMethodExceptionCtor1\\MissingMethodExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
