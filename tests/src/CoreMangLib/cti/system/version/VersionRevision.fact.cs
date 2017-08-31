using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_version_VersionRevision_VersionRevision_
    {
        [OuterLoop]
        [Fact]
        public void _system_version_VersionRevision_VersionRevision_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\version\\VersionRevision\\VersionRevision.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
