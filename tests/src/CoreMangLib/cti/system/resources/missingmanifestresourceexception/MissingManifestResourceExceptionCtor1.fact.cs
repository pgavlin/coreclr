using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_resources_missingmanifestresourceexception_MissingManifestResourceExceptionCtor1_MissingManifestResourceExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_resources_missingmanifestresourceexception_MissingManifestResourceExceptionCtor1_MissingManifestResourceExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\resources\\missingmanifestresourceexception\\MissingManifestResourceExceptionCtor1\\MissingManifestResourceExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
