using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_missingmethodexception_MissingMethodExceptionCtor2_MissingMethodExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_missingmethodexception_MissingMethodExceptionCtor2_MissingMethodExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\missingmethodexception\\MissingMethodExceptionCtor2\\MissingMethodExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
