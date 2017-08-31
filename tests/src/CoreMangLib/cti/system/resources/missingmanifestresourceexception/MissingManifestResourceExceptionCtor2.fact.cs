using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_resources_missingmanifestresourceexception_MissingManifestResourceExceptionCtor2_MissingManifestResourceExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_resources_missingmanifestresourceexception_MissingManifestResourceExceptionCtor2_MissingManifestResourceExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\resources\\missingmanifestresourceexception\\MissingManifestResourceExceptionCtor2\\MissingManifestResourceExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
