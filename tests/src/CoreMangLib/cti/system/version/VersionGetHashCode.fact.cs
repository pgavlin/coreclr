using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_version_VersionGetHashCode_VersionGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_version_VersionGetHashCode_VersionGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\version\\VersionGetHashCode\\VersionGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
