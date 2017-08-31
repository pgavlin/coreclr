using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_guid_GuidEquals2_cti_GuidEquals2_cti_
    {
        [OuterLoop]
        [Fact]
        public void _system_guid_GuidEquals2_cti_GuidEquals2_cti_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\guid\\GuidEquals2_cti\\GuidEquals2_cti.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
