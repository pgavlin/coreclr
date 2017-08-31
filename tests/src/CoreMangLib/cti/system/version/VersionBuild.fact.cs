using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_version_VersionBuild_VersionBuild_
    {
        [OuterLoop]
        [Fact]
        public void _system_version_VersionBuild_VersionBuild_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\version\\VersionBuild\\VersionBuild.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
