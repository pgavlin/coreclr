using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_resources_missingmanifestresourceexception_MissingManifestResourceExceptionCtor3_MissingManifestResourceExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_resources_missingmanifestresourceexception_MissingManifestResourceExceptionCtor3_MissingManifestResourceExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\resources\\missingmanifestresourceexception\\MissingManifestResourceExceptionCtor3\\MissingManifestResourceExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
