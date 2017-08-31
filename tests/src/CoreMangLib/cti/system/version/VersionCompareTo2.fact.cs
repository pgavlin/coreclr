using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_version_VersionCompareTo2_VersionCompareTo2_
    {
        [OuterLoop]
        [Fact]
        public void _system_version_VersionCompareTo2_VersionCompareTo2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\version\\VersionCompareTo2\\VersionCompareTo2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
