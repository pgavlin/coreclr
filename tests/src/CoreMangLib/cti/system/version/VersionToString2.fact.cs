using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_version_VersionToString2_VersionToString2_
    {
        [OuterLoop]
        [Fact]
        public void _system_version_VersionToString2_VersionToString2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\version\\VersionToString2\\VersionToString2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
